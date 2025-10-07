using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Windows.Forms;
using System.Globalization;

namespace Zooka
{
    public partial class AgendamentoHorario : Form
    {
        consulta_cliente conulta = new consulta_cliente();
        Conexao conexao = new Conexao();

        private int _idAgendamentoParaEdicao = 0;

        // Evento para notificar a Agenda
        public delegate void AgendamentoAlteradoHandler();
        public event AgendamentoAlteradoHandler AgendamentoAlterado = delegate { };

        public AgendamentoHorario()
        {
            InitializeComponent();
        }

        public AgendamentoHorario(int idAgendamento)
        {
            InitializeComponent();
            _idAgendamentoParaEdicao = idAgendamento;
        }

        private void AgendamentoHorario_Load(object sender, EventArgs e)
        {
            // [CÓDIGO DE PREENCHIMENTO DE COMBOBOXES]
            cmbStatusAgenda.Items.Clear();
            cmbStatusDia.Items.Clear();
            cmbStatusAgenda.Items.Add("CONFIRMADO");
            cmbStatusAgenda.Items.Add("CANDELADO");
            cmbStatusAgenda.Items.Add("REMARCADO");
            cmbStatusAgenda.Items.Add("COMPARECEU");
            cmbStatusDia.Items.Add("OCUPADO");
            cmbStatusDia.Items.Add("LIVRE");

            if (cmbStatusAgenda.Items.Count > 0) cmbStatusAgenda.SelectedIndex = 0;
            if (cmbStatusDia.Items.Count > 0) cmbStatusDia.SelectedIndex = 0;

            // LÓGICA DE CARREGAMENTO DE DADOS
            if (_idAgendamentoParaEdicao > 0)
            {
                CarregarDadosAgendamento(_idAgendamentoParaEdicao);
                this.Text = "Editar Agendamento ID: " + _idAgendamentoParaEdicao;
                btnSalvar.Text = "ATUALIZAR";
                btnExcluir.Visible = true;
            }
            else
            {
                // MODO NOVO
                string diaString = ControlAgendaDias.static_dia;

                if (int.TryParse(diaString, out int diaNumero))
                {
                    DateTime dataNova = new DateTime(Agenda.static_ano, Agenda.static_mes, diaNumero);
                    txtDia.Text = dataNova.ToString("dd/MM/yyyy");
                }

                txtHora.Text = Agenda.static_hora.ToString();

                txtAgendaCliente.Text = string.Empty;
                txtPet.Text = string.Empty;
                txtProfissional.Text = string.Empty;
                txtServico.Text = string.Empty;

                btnExcluir.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoParaEdicao > 0)
            {
                ExecutarAtualizarAgendamento();
            }
            else
            {
                ExecutarSalvarAgendamento();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoParaEdicao > 0)
            {
                ExecutarExclusaoAgendamento();
            }
        }

        // --- FUNÇÕES DE EXECUÇÃO ---

        private void ExecutarAtualizarAgendamento()
        {
            string diaTexto = txtDia.Text;
            string diaMySql;

            try
            {
                DateTime dataObjeto = DateTime.ParseExact(diaTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                diaMySql = dataObjeto.ToString("yyyy-MM-dd");
            }
            catch (FormatException)
            {
                MessageBox.Show("A data deve estar no formato DD/MM/AAAA (ex: 01/10/2025).", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hora = txtHora.Text;
            string statusAgenda = cmbStatusAgenda.SelectedItem.ToString();
            string statusDia = cmbStatusDia.SelectedItem.ToString();

            int idCliente = GetIdPeloNome("cliente", "id_cliente", "nome_cliente", txtAgendaCliente.Text);
            int idPet = GetIdPeloNome("pet", "id_pet", "nome_pet", txtPet.Text);
            int idProfissional = GetIdPeloNome("profissional", "id_profissional", "nome_profissional", txtProfissional.Text);
            int idServico = GetIdPeloNome("servico", "id_servico", "nome_servico", txtServico.Text);

            if (idCliente == 0 || idPet == 0 || idProfissional == 0 || idServico == 0)
            {
                MessageBox.Show("Um ou mais campos (Cliente/Pet/Profissional/Serviço) são obrigatórios.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = conexao.GetConnection())
            {
                string comando = @"
                    UPDATE agenda_vet SET 
                        id_cliente = @cliente, id_pet = @pet, id_profissional = @profissional, 
                        id_servico = @servico, horario = @hora, data_agendamento = @dia, 
                        status_agenda_vet = @statusAgenda, status_dia_horario_agenda_vet = @statusDia 
                    WHERE id_agenda_vet = @idEdicao";

                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", idCliente);
                        cmd.Parameters.AddWithValue("@pet", idPet);
                        cmd.Parameters.AddWithValue("@profissional", idProfissional);
                        cmd.Parameters.AddWithValue("@servico", idServico);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@dia", diaMySql);
                        cmd.Parameters.AddWithValue("@statusAgenda", statusAgenda);
                        cmd.Parameters.AddWithValue("@statusDia", statusDia);
                        cmd.Parameters.AddWithValue("@idEdicao", _idAgendamentoParaEdicao);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // NOTIFICAÇÃO: Chama o evento de notificação
                        AgendamentoAlterado?.Invoke();
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao atualizar agendamento: {ex.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExecutarSalvarAgendamento()
        {
            string diaTexto = txtDia.Text;
            string diaMySql;

            try
            {
                DateTime dataObjeto = DateTime.ParseExact(diaTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                diaMySql = dataObjeto.ToString("yyyy-MM-dd");
            }
            catch (FormatException)
            {
                MessageBox.Show("A data deve estar no formato DD/MM/AAAA (ex: 01/10/2025).", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hora = txtHora.Text;
            string statusAgenda = cmbStatusAgenda.SelectedItem.ToString();
            string statusDia = cmbStatusDia.SelectedItem.ToString();

            int idCliente = GetIdPeloNome("cliente", "id_cliente", "nome_cliente", txtAgendaCliente.Text);
            int idPet = GetIdPeloNome("pet", "id_pet", "nome_pet", txtPet.Text);
            int idProfissional = GetIdPeloNome("profissional", "id_profissional", "nome_profissional", txtProfissional.Text);
            int idServico = GetIdPeloNome("servico", "id_servico", "nome_servico", txtServico.Text);

            if (idCliente == 0 || idPet == 0 || idProfissional == 0 || idServico == 0)
            {
                MessageBox.Show("Um ou mais campos (Cliente/Pet/Profissional/Serviço) são obrigatórios.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = conexao.GetConnection())
            {
                string comando = "INSERT INTO agenda_vet (id_cliente, id_pet, id_profissional, id_servico, horario, data_agendamento , status_agenda_vet, status_dia_horario_agenda_vet) " +
                                 "VALUES (@cliente, @pet, @profissional, @servico, @hora, @dia, @statusAgenda, @statusDia)";
                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", idCliente);
                        cmd.Parameters.AddWithValue("@pet", idPet);
                        cmd.Parameters.AddWithValue("@profissional", idProfissional);
                        cmd.Parameters.AddWithValue("@servico", idServico);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@dia", diaMySql);
                        cmd.Parameters.AddWithValue("@statusAgenda", statusAgenda);
                        cmd.Parameters.AddWithValue("@statusDia", statusDia);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // NOTIFICAÇÃO: Chama o evento de notificação
                        AgendamentoAlterado?.Invoke();
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao salvar agendamento: {ex.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExecutarExclusaoAgendamento()
        {
            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja EXCLUIR este agendamento? Esta ação é irreversível.",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No) return;

            using (var conn = conexao.GetConnection())
            {
                string comando = "DELETE FROM agenda_vet WHERE id_agenda_vet = @idExclusao";

                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@idExclusao", _idAgendamentoParaEdicao);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // NOTIFICAÇÃO: Chama o evento de notificação
                        AgendamentoAlterado?.Invoke();
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao excluir agendamento: {ex.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- MÉTODOS DE BUSCA E CARREGAMENTO ---

        private int GetIdPeloNome(string tabela, string colunaId, string colunaNome, string nomeBuscado)
        {
            if (string.IsNullOrWhiteSpace(nomeBuscado)) return 0;

            int idEncontrado = 0;
            string sql = $"SELECT {colunaId} FROM {tabela} WHERE LOWER({colunaNome}) LIKE @nome LIMIT 1";

            using (var conn = conexao.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                try
                {
                    string nomeComCoringas = $"%{nomeBuscado.Trim()}%";
                    cmd.Parameters.AddWithValue("@nome", nomeComCoringas.ToLower());
                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        idEncontrado = Convert.ToInt32(resultado);
                    }
                    return idEncontrado;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar ID na tabela {tabela}: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return idEncontrado;
                }
            }
        }

        private void CarregarDadosAgendamento(int id)
        {
            string comando = @"
                SELECT 
                    t1.*, t2.nome_cliente, t3.nome_pet, t4.nome_servico, t5.nome_profissional
                FROM agenda_vet t1
                JOIN cliente t2 ON t1.id_cliente = t2.id_cliente 
                JOIN pet t3 ON t1.id_pet = t3.id_pet 
                JOIN servico t4 ON t1.id_servico = t4.id_servico 
                JOIN profissional t5 ON t1.id_profissional = t5.id_profissional 
                WHERE t1.id_agenda_vet = @idAgendamento LIMIT 1";

            using (var conn = conexao.GetConnection())
            {
                using (var cmd = new MySqlCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@idAgendamento", id);
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Converte a data do banco (AAAA-MM-DD) para o formato brasileiro (DD/MM/AAAA)
                            DateTime dataDoBanco = DateTime.Parse(reader["data_agendamento"].ToString());
                            txtDia.Text = dataDoBanco.ToString("dd/MM/yyyy");

                            txtHora.Text = reader["horario"].ToString();

                            txtAgendaCliente.Text = reader["nome_cliente"].ToString();
                            txtPet.Text = reader["nome_pet"].ToString();
                            txtProfissional.Text = reader["nome_profissional"].ToString();
                            txtServico.Text = reader["nome_servico"].ToString();

                            cmbStatusAgenda.SelectedItem = reader["status_agenda_vet"].ToString();
                            cmbStatusDia.SelectedItem = reader["status_dia_horario_agenda_vet"].ToString();
                        }
                        reader.Dispose();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }
    }
}