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

        public static string static_dia;
        private string _diaDoCard;
        public int IdAgendamento { get; private set; } = 0;

        public ControlAgendaDias()
        {
            InitializeComponent();
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
                agendamentoHorario.ShowDialog();
            }
            else
            {
                static_dia = _diaDoCard;
                timer1.Start();
                agendamentoHorario = new AgendamentoHorario();
                agendamentoHorario.Show();
            }
            // A atualização será feita pelo formulário Agenda após o retorno do ShowDialog
        }

        private void displayDetalheAgenda()
        {
            if (string.IsNullOrEmpty(_diaDoCard))
            {
                lblDetalheAgenda.Text = "Aguardando Dia...";
                lblDetalheAgenda.BackColor = Color.LightGray;
                IdAgendamento = 0;
                return;
            }

            IdAgendamento = 0;
            string diaFormatado = _diaDoCard.PadLeft(2, '0');
            string dataAgenda = Agenda.static_ano + "-" + Agenda.static_mes + "-" + diaFormatado;

            // FIX FINAL: Adiciona SQL_NO_CACHE para forçar o MySQL a ler o dado mais atualizado
            string comando = @"
                SELECT 
                    SQL_NO_CACHE t1.horario, 
                    t1.id_agenda_vet, 
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
                            int total = Convert.ToInt32(reader["total_agendamentos"]);

                            lblDetalheAgenda.Text =
                                $"{horario}\n {nomeCliente}\n {nomePet}\n {nomeServico}\n {nomeProfissional}\n";

                            if (total > 1)
                            {
                                lblDetalheAgenda.Text += $"\n(+ {total - 1} agendamentos)";
                                lblDetalheAgenda.BackColor = Color.Orange;
                            }
                            else
                            {
                                lblDetalheAgenda.BackColor = Color.LightBlue;
                            }
                        }
                        else
                        {
                            lblDetalheAgenda.Text = "";
                            lblDetalheAgenda.BackColor = Color.LightGray;
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

        private void timer1_Tick(object sender, EventArgs e) { displayDetalheAgenda(); }
        private void ControlAgendaDias_Load(object sender, EventArgs e) { }
        private void ControlAgendaDias_Load_1(object sender, EventArgs e) { }
        private void displayCalendario() { }
        private void lblDetalheAgenda_Click(object sender, EventArgs e) { }
    }
}