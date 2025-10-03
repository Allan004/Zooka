using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using SisVendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zooka
{
    public partial class AgendamentoHorario : Form
    {
        consulta_cliente conulta = new consulta_cliente();
        Conexao conexao = new Conexao();
        public AgendamentoHorario()
        {
            InitializeComponent();
        }

        private void AgendamentoHorario_Load(object sender, EventArgs e)
        {
            txtDia.Text = Agenda.static_ano + "-" + Agenda.static_mes + "-" + ControlAgendaDias.static_dia;
            txtHora.Text = Agenda.static_hora.ToString();

            cmbStatusAgenda.Items.Clear();
            cmbStatusDia.Items.Clear();

            cmbStatusAgenda.Items.Add("CONFIRMADO");
            cmbStatusAgenda.Items.Add("CANDELADO");
            cmbStatusAgenda.Items.Add("REMARCADO");
            cmbStatusAgenda.Items.Add("COMPARECEU");

            cmbStatusDia.Items.Add("OCUPADO");
            cmbStatusDia.Items.Add("LIVRE");


            if (cmbStatusAgenda.Items.Count > 0)
            {
                cmbStatusAgenda.SelectedIndex = 0;
            }

            if (cmbStatusDia.Items.Count > 0)
            {
                cmbStatusDia.SelectedIndex = 0;
            }

        }

        private int GetIdPeloNome(string tabela, string colunaId, string colunaNome, string nomeBuscado)
        {
            int idEncontrado = 0;

            // ATENÇÃO: Mudança aqui! Usando 'LIKE' com '%' para buscar correspondências parciais.
            // O nome é envolvido em coringas '%' para permitir que o usuário digite parte do nome.
            // Ex: Se o usuário digitar "João", ele encontra "João da Silva".
            string sql = $"SELECT {colunaId} FROM {tabela} WHERE LOWER({colunaNome}) LIKE @nome LIMIT 1";

            try
            {
                using (var conn = conexao.GetConnection())
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    // Adiciona o valor do parâmetro envolvido em coringas.
                    // O Trim() é importante para limpar o valor digitado.
                    string nomeComCoringas = $"%{nomeBuscado.Trim()}%";

                    cmd.Parameters.AddWithValue("@nome", nomeComCoringas.ToLower()); // Adiciona o toLower para o MySql
                    conn.Open();

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idEncontrado = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                // ... (Seu tratamento de erro)
            }
            return idEncontrado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            using (var conn = conexao.GetConnection())
            {
                string dia = txtDia.Text;
                string hora = txtHora.Text;
                string statusAgenda = cmbStatusAgenda.SelectedItem.ToString();
                string statusDia = cmbStatusDia.SelectedItem.ToString();
                int idCliente = GetIdPeloNome("cliente", "id_cliente", "nome_cliente", txtAgendaCliente.Text);
                int idPet = GetIdPeloNome("pet", "id_pet", "nome_pet", txtPet.Text);
                int idProfissional = GetIdPeloNome("profissional", "id_profissional", "nome_profissional", txtProfissional.Text);
                int idServico = GetIdPeloNome("servico", "id_servico", "nome_servico", txtServico.Text);

                if (idCliente == 0)
                {
                    MessageBox.Show($"O cliente '{txtAgendaCliente.Text}' não foi encontrado. Verifique o cadastro.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idPet == 0)
                {
                    MessageBox.Show($"O pet '{txtPet.Text}' não foi encontrado. Verifique o cadastro.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idProfissional == 0)
                {
                    MessageBox.Show($"O profissional '{txtProfissional.Text}' não foi encontrado. Verifique o cadastro.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (idServico == 0)
                {
                    MessageBox.Show($"O servico '{txtServico.Text}' não foi encontrado. Verifique o cadastro.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string comando = "INSERT INTO agenda_vet (id_cliente, id_pet, id_profissional, id_servico, horario, data_agenda, status_agenda_vet, status_dia_horario_agenda_vet) " +
                                      "VALUES (@cliente, @pet, @profissional, @servico, @hora, @dia, @statusAgenda, @statusDia)";
                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        // Passando os IDs NUMÉRICOS (chaves estrangeiras)
                        cmd.Parameters.AddWithValue("@cliente", idCliente);
                        cmd.Parameters.AddWithValue("@pet", idPet);
                        cmd.Parameters.AddWithValue("@profissional", idProfissional);
                        cmd.Parameters.AddWithValue("@servico", idServico);

                        // Passando os dados de agendamento (strings)
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@dia", dia);
                        cmd.Parameters.AddWithValue("@statusAgenda", statusAgenda);
                        cmd.Parameters.AddWithValue("@statusDia", statusDia);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao salvar agendamento: {ex.Message}\nVerifique a conexão e os tipos de dados.", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
