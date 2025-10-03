using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ControlAgendaDias : UserControl
    {
        // Certifique-se de que o objeto conexao foi instanciado corretamente
        Conexao conexao = new Conexao();

        public static string static_dia;

        public ControlAgendaDias()
        {
            InitializeComponent();
        }

        // Método chamado pelo Formulário Agenda para definir o dia no label
        public void days(int numDia)
        {
            lblDia.Text = numDia.ToString();
            // Chamamos o displayDetalheAgenda aqui para carregar os dados
            // assim que o card do dia for criado.
            displayDetalheAgenda();
        }

        // Este é o método que abre o formulário de agendamento e inicia o timer
        private void ControleAgendaDias(object sender, EventArgs e)
        {
            static_dia = lblDia.Text;
            timer1.Start();
            AgendamentoHorario agendamentoHorario = new AgendamentoHorario();
            agendamentoHorario.Show();
        }

        private void displayDetalheAgenda()
        {
            // Verifica se o dia é válido antes de formatar
            if (string.IsNullOrEmpty(ControlAgendaDias.static_dia))
            {
                lblDetalheAgenda.Text = "Aguardando Dia...";
                lblDetalheAgenda.BackColor = Color.LightGray;
                return;
            }

            // Formata o dia para 2 dígitos (ex: '1' vira '01')
            string diaFormatado = ControlAgendaDias.static_dia.PadLeft(2, '0');

            // Monta a data no formato YYYY-MM-DD
            string dataAgenda = Agenda.static_ano + "-" + Agenda.static_mes + "-" + diaFormatado;

            // QUERY DE BUSCA FINAL COM QUATRO JOINS
            string comando = @"
            SELECT 
                t1.horario, 
                t2.nome_cliente,
                t3.nome_pet, -- Nome do Pet (Tabela pet)
                t4.nome_servico, -- Nome do Serviço (Tabela servico)
                t5.nome_profissional, -- Nome do Profissional (Tabela profissional)
                (SELECT COUNT(*) FROM agenda_vet 
                WHERE data_agenda = @dataAgenda) as total_agendamentos
            FROM agenda_vet t1
                JOIN cliente t2 ON t1.id_cliente = t2.id_cliente -- Cliente (t2)
                JOIN pet t3 ON t1.id_pet = t3.id_pet -- Pet (t3)
                JOIN servico t4 ON t1.id_servico = t4.id_servico -- Serviço (t4)
                JOIN profissional t5 ON t1.id_profissional = t5.id_profissional -- Profissional (t5)
                WHERE t1.data_agenda = @dataAgenda
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
                            // 1. RECUPERAÇÃO DOS DADOS
                            string nomeCliente = reader["nome_cliente"].ToString();
                            string nomePet = reader["nome_pet"].ToString();
                            string nomeServico = reader["nome_servico"].ToString();
                            string nomeProfissional = reader["nome_profissional"].ToString();
                            string horario = reader["horario"].ToString();
                            int total = Convert.ToInt32(reader["total_agendamentos"]);

                            // 2. FORMATAÇÃO DA EXIBIÇÃO
                            lblDetalheAgenda.Text =
                                $"{horario}\n  {nomeCliente}\n  {nomePet}\n({nomeServico}\n  {nomeProfissional}\n)";

                            // 3. EXIBIÇÃO DA CONTAGEM
                            if (total > 1)
                            {
                                lblDetalheAgenda.Text += $"\n(+ {total - 1} agendamentos)";
                                lblDetalheAgenda.BackColor = Color.Orange;
                            }
                            else
                            {
                                lblDetalheAgenda.BackColor = Color.Green;
                            }
                        }
                        else
                        {
                            lblDetalheAgenda.Text = "Vazio";
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

        // Chama o método displayDetalheAgenda() a cada tick (para atualização em tempo real, se o AgendamentoHorario estiver aberto)
        private void timer1_Tick(object sender, EventArgs e)
        {
            displayDetalheAgenda();
        }

        // Métodos de evento vazios (pode ignorar ou remover se não forem usados)
        private void ControlAgendaDias_Load(object sender, EventArgs e) { }
        private void ControlAgendaDias_Load_1(object sender, EventArgs e) { }
        private void displayCalendario() { /* ... */ }
        private void lblDetalheAgenda_Click(object sender, EventArgs e) { }
    }
}