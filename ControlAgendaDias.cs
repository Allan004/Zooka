using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Zooka
{
    public partial class ControlAgendaDias : UserControl
    {
        Conexao conexao = new Conexao();
        // Variável estática (compartilhada) usada SOMENTE ao clicar para abrir o AgendamentoHorario
        public static string static_dia;
        // NOVO: Variável interna (privada) para guardar o dia DESTE cartão, resolvendo o problema de repetição.
        private string _diaDoCard;
        public ControlAgendaDias()
        {
            InitializeComponent();
        }
        // Método que recebe o dia e inicia a exibição dos dados
        public void days(int numDia)
        {
            lblDia.Text = numDia.ToString();
            // PASSO 1: Armazena o dia DESTE cartão na variável interna
            _diaDoCard = numDia.ToString();
            displayDetalheAgenda();
        }
        // Este método abre o formulário de agendamento e inicia o timer
        private void ControleAgendaDias(object sender, EventArgs e)
        {
            // Usa a variável estática (global) APENAS para passar o dia para o novo formulário
            static_dia = _diaDoCard;
            timer1.Start();
            AgendamentoHorario agendamentoHorario = new AgendamentoHorario();
            agendamentoHorario.Show();
        }
        // MÉTODO PRINCIPAL DE BUSCA E EXIBIÇÃO NO CARD
        private void displayDetalheAgenda()
        {
            // 1. VALIDAÇÃO E MONTAGEM DA DATA (usando a variável interna _diaDoCard)
            if (string.IsNullOrEmpty(_diaDoCard))
            {
                lblDetalheAgenda.Text = "Aguardando Dia...";
                lblDetalheAgenda.BackColor = Color.LightGray;
                return;
            }
            // Garante que o dia seja formatado corretamente
            string diaFormatado = _diaDoCard.PadLeft(2, '0');
            string dataAgenda = Agenda.static_ano + "-" + Agenda.static_mes + "-" + diaFormatado;
            // 2. QUERY DE BUSCA FINAL COM TODOS OS JOINS E FIX DO DATETIME
            string comando = @"
               SELECT
                   t1.horario,
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
                            // 3. RECUPERAÇÃO E FORMATO DOS DADOS
                            string nomeCliente = reader["nome_cliente"].ToString();
                            string nomePet = reader["nome_pet"].ToString();
                            string nomeServico = reader["nome_servico"].ToString();
                            string nomeProfissional = reader["nome_profissional"].ToString();
                            string horario = reader["horario"].ToString();
                            int total = Convert.ToInt32(reader["total_agendamentos"]);
                            

                            // Formatação da exibição no card
                            lblDetalheAgenda.Text =
                                $"{horario}\n {nomeCliente}\n {nomePet}\n {nomeServico}\n {nomeProfissional}\n";
                            // Contagem e cor do card
                            if (total > 1)
                            {
                                lblDetalheAgenda.Text += $"\n(+ {total - 1} agendamentos)";
                                lblDetalheAgenda.BackColor = Color.Orange; // Múltiplos
                            }
                            else
                            {
                                lblDetalheAgenda.BackColor = Color.LightBlue; // Apenas um
                            }
                        }
                        else
                        {
                            // Nenhum agendamento encontrado
                            lblDetalheAgenda.Text = "VAZIO";
                            lblDetalheAgenda.BackColor = Color.LightGray;
                        }
                        reader.Dispose();
                    }
                    catch (MySqlException ex)
                    {
                        // Mensagem de erro do SQL
                        lblDetalheAgenda.Text = "ERRO SQL: " + ex.Message;
                        lblDetalheAgenda.BackColor = Color.Red;
                    }
                }
            }
        }
        // Chama o displayDetalheAgenda() a cada tick (para atualização)
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayDetalheAgenda();
        }
        // Métodos de evento vazios
        private void ControlAgendaDias_Load(object sender, EventArgs e) { }
        private void ControlAgendaDias_Load_1(object sender, EventArgs e) { }
        private void displayCalendario() { }
        private void lblDetalheAgenda_Click(object sender, EventArgs e) { }
    }
}