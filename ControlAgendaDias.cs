using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Zooka
{
    /// <summary>
    /// Representa um controle de usuário (card) para um dia específico na grade do calendário.
    /// É responsável por exibir o dia e o resumo do agendamento, além de iniciar os formulários CRUD.
    /// </summary>
    public partial class ControlAgendaDias : UserControl
    {
        // Instância de conexão com o banco de dados. (NOTA: Viola o SRP. O ideal é usar um Repositório.)
        Conexao conexao = new Conexao();

        // Objeto ToolTip para exibir detalhes do agendamento ao passar o mouse.
        private ToolTip agendaToolTip = new ToolTip();

        // Variável estática usada para transferir o dia clicado para o formulário de agendamento.
        // (NOTA: Anti-padrão. Os dados deveriam ser passados via construtor do formulário.)
        public static string static_dia;
        private string _diaDoCard;
        // Propriedade que armazena o ID do agendamento lido do banco para o dia.
        public int IdAgendamento { get; private set; } = 0;

        public ControlAgendaDias()
        {
            InitializeComponent();

            // Configuração visual do ToolTip para melhor usabilidade.
            agendaToolTip.OwnerDraw = false;
            agendaToolTip.IsBalloon = true;
            agendaToolTip.ToolTipIcon = ToolTipIcon.Info;
            agendaToolTip.ToolTipTitle = "Detalhes do Agendamento";
            // ... (Demais configurações de cor do ToolTip)
        }

        /// <summary>
        /// Método de inicialização que define o número do dia e dispara a busca por agendamentos.
        /// </summary>
        /// <param name="numDia">O número do dia a ser exibido no card.</param>
        public void days(int numDia)
        {
            lblDia.Text = numDia.ToString();
            _diaDoCard = numDia.ToString();
            displayDetalheAgenda(); // Inicia a consulta ao banco de dados.
        }

        /// <summary>
        /// Handler de clique (provavelmente duplo clique) que abre o formulário de Agendamento.
        /// </summary>
        private void ControleAgendaDias(object sender, EventArgs e)
        {
            // Verifica se está abrindo em modo Edição (se IdAgendamento > 0) ou Inclusão.
            AgendamentoHorario agendamentoHorario;

            if (IdAgendamento > 0)
            {
                // Modo Edição: passa o ID para o construtor.
                agendamentoHorario = new AgendamentoHorario(IdAgendamento);
                // Assina o evento para que a tela principal (Agenda) recarregue após a alteração.
                agendamentoHorario.AgendamentoAlterado += ((Agenda)this.FindForm()).displayDias;
                agendamentoHorario.ShowDialog();
            }
            else
            {
                // Modo Inclusão: Transfere o dia usando a variável estática (anti-padrão).
                static_dia = _diaDoCard;
                timer1.Start(); // Inicia um timer (uso incerto aqui).
                agendamentoHorario = new AgendamentoHorario();
                agendamentoHorario.AgendamentoAlterado += ((Agenda)this.FindForm()).displayDias;
                agendamentoHorario.ShowDialog();
            }

            displayDetalheAgenda(); // Recarrega os dados do card após o fechamento do formulário.
        }

        /// <summary>
        /// Consulta o banco de dados para verificar e exibir os detalhes do agendamento para a data do card.
        /// </summary>
        private void displayDetalheAgenda()
        {
            // Validação básica se o dia do mês está definido.
            if (string.IsNullOrEmpty(_diaDoCard))
            {
                IdAgendamento = 0;
                return;
            }

            IdAgendamento = 0;
            // Constrói a data no formato YYYY-MM-DD usando variáveis estáticas globais.
            string diaFormatado = _diaDoCard.PadLeft(2, '0');
            string dataAgenda = Agenda.static_ano + "-" + Agenda.static_mes + "-" + diaFormatado;


            // Query complexa com múltiplos JOINS e subconsulta (para total_agendamentos).
            // NOTA: O uso de LIMIT 1 significa que apenas o primeiro agendamento do dia é exibido no card.
            string comando = $@"
                SELECT 
                    SQL_NO_CACHE 
                    t1.horario, t1.id_agenda_vet, t1.status_agenda_vet, t2.nome_cliente,
                    t3.nome_pet,t4.nome_servico,t5.nome_profissional,
               (SELECT COUNT(*) FROM agenda_vet 
                WHERE DATE(data_agendamento) = @dataAgenda) as total_agendamentos
                FROM agenda_vet t1
                JOIN cliente t2 ON t1.id_cliente = t2.id_cliente 
                JOIN pet t3 ON t1.id_pet = t3.id_pet 
                JOIN servico t4 ON t1.id_servico = t4.id_servico 
                JOIN profissional t5 ON t1.id_profissional = t5.id_profissional 
                WHERE DATE(t1.data_agendamento) = @dataAgenda
                LIMIT 1;";

            // Bloco de Acesso a Dados (DB)
            using (var conn = conexao.GetConnection())
            {
                using (var cmd = new MySqlCommand(comando, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@dataAgenda", dataAgenda);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Mapeamento dos dados lidos para as propriedades do card.
                            IdAgendamento = Convert.ToInt32(reader["id_agenda_vet"]);
                            string status = reader["status_agenda_vet"].ToString();
                            int total = Convert.ToInt32(reader["total_agendamentos"]);

                            // Preenche o texto visível no card com o resumo.
                            lblDetalheAgenda.Text =
                                $"{reader["horario"]}\n {reader["nome_cliente"]}\n {reader["nome_pet"]}\n {reader["nome_servico"]}\n {reader["nome_profissional"]}\n";

                            // Constrói o texto detalhado do ToolTip.
                            string toolTipText =
                                $"Horário: {reader["horario"]}\n Cliente: {reader["nome_cliente"]}\n ...";

                            // Lógica de cores baseada no STATUS (string mágica).
                            switch (status)
                            {
                                case "CONFIRMADO": lblDetalheAgenda.BackColor = Color.LightBlue; break;
                                case "CANCELADO": lblDetalheAgenda.BackColor = Color.Red; break;
                                case "REMARCADO": lblDetalheAgenda.BackColor = Color.Orange; break;
                                case "COMPARECEU": lblDetalheAgenda.BackColor = Color.Green; break;
                                default: lblDetalheAgenda.BackColor = Color.LightBlue; break;
                            }

                            // Sobrescrita de cor e texto para indicar múltiplos agendamentos.
                            if (total > 1)
                            {
                                lblDetalheAgenda.Text += $"\n(+ {total - 1} agendamentos)";
                                toolTipText += $"\n--- Múltiplos Agendamentos ({total}) ---";
                                lblDetalheAgenda.BackColor = Color.Gray;
                            }

                            agendaToolTip.SetToolTip(lblDetalheAgenda, toolTipText);
                        }
                        else
                        {
                            // Caso não haja agendamentos, o card é limpo.
                            lblDetalheAgenda.Text = "";
                            lblDetalheAgenda.BackColor = Color.LightGray;
                            agendaToolTip.SetToolTip(lblDetalheAgenda, "");
                        }

                        reader.Dispose();
                    }
                    catch (MySqlException ex)
                    {
                        // Exibe erros de SQL diretamente na interface (deve ser logging profissional).
                        lblDetalheAgenda.Text = "ERRO SQL: " + ex.Message;
                        lblDetalheAgenda.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}


