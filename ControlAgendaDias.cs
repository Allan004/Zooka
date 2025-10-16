using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Zooka
{
    public partial class ControlAgendaDias : UserControl
    {
        Conexao conexao = new Conexao();

        private ToolTip agendaToolTip = new ToolTip();

        public static string static_dia;
        private string _diaDoCard;
        public int IdAgendamento { get; private set; } = 0;

        public ControlAgendaDias()
        {
            InitializeComponent();

            // --- ESTILIZAÇÃO DO TOOLTIP PADRÃO ---
            agendaToolTip.OwnerDraw = false;
            agendaToolTip.IsBalloon = true;
            agendaToolTip.ToolTipIcon = ToolTipIcon.Info;
            agendaToolTip.ToolTipTitle = "Detalhes do Agendamento";
            agendaToolTip.BackColor = SystemColors.Info;
            agendaToolTip.ForeColor = SystemColors.ControlText;
            // ------------------------------------
        }

        public void days(int numDia)
        {
            lblDia.Text = numDia.ToString();
            _diaDoCard = numDia.ToString();
            displayDetalheAgenda();
        }

        private void ControleAgendaDias(object sender, EventArgs e)
        {
            AgendamentoHorario agendamentoHorario;

            if (IdAgendamento > 0)
            {
                agendamentoHorario = new AgendamentoHorario(IdAgendamento);
                agendamentoHorario.AgendamentoAlterado += ((Agenda)this.FindForm()).displayDias;
                agendamentoHorario.ShowDialog();
            }
            else
            {
                static_dia = _diaDoCard;
                timer1.Start();
                agendamentoHorario = new AgendamentoHorario();
                agendamentoHorario.AgendamentoAlterado += ((Agenda)this.FindForm()).displayDias;
                agendamentoHorario.ShowDialog();
            }

            displayDetalheAgenda();
        }

        private void displayDetalheAgenda()
        {
            if (string.IsNullOrEmpty(_diaDoCard))
            {
                agendaToolTip.SetToolTip(lblDetalheAgenda, "");
                lblDetalheAgenda.Text = "";
                lblDetalheAgenda.BackColor = Color.LightGray;
                IdAgendamento = 0;
                return;
            }

            IdAgendamento = 0;
            string diaFormatado = _diaDoCard.PadLeft(2, '0');
            string dataAgenda = Agenda.static_ano + "-" + Agenda.static_mes + "-" + diaFormatado;


            string comando = @"
                SELECT 
                    SQL_NO_CACHE t1.horario, 
                    t1.id_agenda_vet, 
                    t1.status_agenda_vet, 
                    t2.nome_cliente,
                    t3.nome_pet,
                    t4.nome_servico,
                    t5.nome_profissional,
                    (SELECT COUNT(*) FROM agenda_vet 
                    WHERE DATE(data_agendamento) = @dataAgenda) as total_agendamentos
                FROM agenda_vet t1
                JOIN cliente t2 ON t1.id_cliente = t2.id_cliente 
                JOIN pet t3 ON t1.id_pet = t3.id_pet 
                JOIN servico t4 ON t1.id_servico = t4.id_servico 
                JOIN profissional t5 ON t1.id_profissional = t5.id_profissional 
                WHERE DATE(t1.data_agendamento) = @dataAgenda
                LIMIT 1;";

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
                            IdAgendamento = Convert.ToInt32(reader["id_agenda_vet"]);

                            string nomeCliente = reader["nome_cliente"].ToString();
                            string nomePet = reader["nome_pet"].ToString();
                            string nomeServico = reader["nome_servico"].ToString();
                            string nomeProfissional = reader["nome_profissional"].ToString();
                            string horario = reader["horario"].ToString();
                            string status = reader["status_agenda_vet"].ToString(); // Pega o status para a cor
                            int total = Convert.ToInt32(reader["total_agendamentos"]);

                            // Texto que aparece no card
                            lblDetalheAgenda.Text =
                                $"{horario}\n {nomeCliente}\n {nomePet}\n {nomeServico}\n {nomeProfissional}\n";

                            // Constrói o ToolTip
                            string toolTipText =
                                $"Horário: {horario}\n" +
                                $"Cliente: {nomeCliente}\n" +
                                $"Pet: {nomePet}\n" +
                                $"Serviço: {nomeServico}\n" +
                                $"Profissional: {nomeProfissional}";

                            // --- LÓGICA DE COR FINAL COM STATUS CORRIGIDOS ---
                            switch (status)
                            {
                                case "CONFIRMADO": lblDetalheAgenda.BackColor = Color.LightBlue; break;
                                case "CANCELADO": lblDetalheAgenda.BackColor = Color.Red; break;       // Assume que 'CANDELADO' é o que está sendo salvo (Cancelado)
                                case "REMARCADO": lblDetalheAgenda.BackColor = Color.Orange; break;     // Cor adicionada (Laranja)
                                case "COMPARECEU": lblDetalheAgenda.BackColor = Color.Green; break;     // Sucesso/Conclusão
                                default: lblDetalheAgenda.BackColor = Color.LightBlue; break;
                            }

                            if (total > 1)
                            {
                                lblDetalheAgenda.Text += $"\n(+ {total - 1} agendamentos)";
                                toolTipText += $"\n--- Múltiplos Agendamentos ({total}) ---";
                                lblDetalheAgenda.BackColor = Color.Gray; // Sobrescreve para Cinza se houver muitos
                            }

                            agendaToolTip.SetToolTip(lblDetalheAgenda, toolTipText);
                        }
                        else
                        {
                            lblDetalheAgenda.Text = "";
                            lblDetalheAgenda.BackColor = Color.LightGray;
                            agendaToolTip.SetToolTip(lblDetalheAgenda, "");
                        }

                        reader.Dispose();
                    }
                    catch (MySqlException ex)
                    {
                        lblDetalheAgenda.Text = "ERRO SQL: " + ex.Message;
                        lblDetalheAgenda.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ControlAgendaDias_Load_1(object sender, EventArgs e) { }
        private void timer1_Tick(object sender, EventArgs e) { displayDetalheAgenda(); }

    }
}