using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Zooka
{
    public partial class AgendamentoHorario : Form
    {
        Conexao conexao = new Conexao();
        consulta_cliente conulta = new consulta_cliente();

        private int _idAgendamentoParaEdicao = 0;

        // Estrutura interna para armazenar os pets carregados.
        private List<(int Id, string Nome, string Raca, string Especie)> _petsDoCliente =
            new List<(int, string, string, string)>();

        public delegate void AgendamentoAlteradoHandler();
        public event AgendamentoAlteradoHandler AgendamentoAlterado = delegate { };

        public AgendamentoHorario()
        {
            InitializeComponent();
            // Associa handlers de eventos dinamicamente para garantir a funcionalidade.
            this.cmbPet.SelectedIndexChanged += cbmPet_SelectedIndexChanged;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
        }

        public AgendamentoHorario(int idAgendamento)
        {
            InitializeComponent();
            _idAgendamentoParaEdicao = idAgendamento;
            this.cmbPet.SelectedIndexChanged += cbmPet_SelectedIndexChanged;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
        }

        private void AgendamentoHorario_Load(object sender, EventArgs e)
        {
            if (_idAgendamentoParaEdicao > 0)
            {
                CarregarDadosAgendamento(_idAgendamentoParaEdicao);
                this.Text = "Editar Agendamento ID: " + _idAgendamentoParaEdicao;
                btnSalvar.Text = "ATUALIZAR";
                btnExcluir.Visible = true;
            }
            else
            {
                string diaString = ControlAgendaDias.static_dia;

                if (int.TryParse(diaString, out int diaNumero))
                {
                    DateTime dataNova = new DateTime(Agenda.static_ano, Agenda.static_mes, diaNumero);
                    txtDia.Text = dataNova.ToString("dd/MM/yyyy");
                }

                txtHora.Text = Agenda.static_hora.ToString();

                txtAgendaCliente.Text = string.Empty;
                LimparCampoPet();
                txtProfissional.Text = string.Empty;
                txtServico.Text = string.Empty;
                txtObservacao.Text = string.Empty;

                btnExcluir.Visible = false;
            }
        }

        // --- LÓGICA DE BUSCA E GATILHOS ---

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            string cpfLimpo = txtCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();

            if (string.IsNullOrWhiteSpace(cpfLimpo) || cpfLimpo.Length != 11)
            {
                LimparCampoClienteEPet();
                return;
            }

            if (txtCpf.MaskCompleted)
            {
                CarregarClienteEPetsPeloCPF(cpfLimpo);
            }
            else
            {
                LimparCampoClienteEPet();
            }
        }

        private void LimparCampoClienteEPet()
        {
            txtAgendaCliente.Clear();
            LimparCampoPet();
        }

        private void LimparCampoPet()
        {
            _petsDoCliente.Clear();
            cmbPet.DataSource = null;
            cmbPet.Text = string.Empty;
            txtRaca.Clear();
            txtEspecie.Clear();
        }

        private void cbmPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPet.SelectedIndex != -1)
            {
                int selectedIndex = cmbPet.SelectedIndex;

                if (selectedIndex >= 0 && selectedIndex < _petsDoCliente.Count)
                {
                    var petSelecionado = _petsDoCliente[selectedIndex];

                    txtRaca.Text = petSelecionado.Raca;
                    txtEspecie.Text = petSelecionado.Especie;
                }
            }
            else
            {
                txtRaca.Clear();
                txtEspecie.Clear();
            }
        }


        private void CarregarClienteEPetsPeloCPF(string cpf)
        {
            (int id, string nome) cliente = BuscarClientePorCPF(cpf);

            LimparCampoPet();
            txtAgendaCliente.Text = string.Empty;

            if (cliente.id > 0)
            {
                txtAgendaCliente.Text = cliente.nome;

                try
                {
                    _petsDoCliente = BuscarPetsPorClienteId(cliente.id);

                    if (_petsDoCliente.Count > 0)
                    {
                        cmbPet.DataSource = _petsDoCliente.Select(p => p.Nome).ToList();

                        cmbPet.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbPet.Text = "Nenhum Pet encontrado.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar pets: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPet.Text = "Erro na busca.";
                }
            }
            else
            {
                txtAgendaCliente.Text = "Cliente não encontrado.";
                cmbPet.Text = string.Empty;
            }
        }

        // --- MÉTODOS DE BUSCA E ACESSO A DADOS ---

        private List<(int Id, string Nome, string Raca, string Especie)> BuscarPetsPorClienteId(int idCliente)
        {
            List<(int Id, string Nome, string Raca, string Especie)> pets =
                new List<(int, string, string, string)>();

            string comando = $@"
                SELECT 
                    id_pet, 
                    nome_pet, 
                    raca_pet, 
                    especie_pet 
                FROM pet 
                WHERE id_cliente = @idCliente";

            using (var conn = conexao.GetConnection())
            using (var cmd = new MySqlCommand(comando, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        pets.Add((
                            Id: Convert.ToInt32(reader["id_pet"]),
                            Nome: reader["nome_pet"].ToString(),
                            Raca: reader["raca_pet"] as string ?? string.Empty,
                            Especie: reader["especie_pet"] as string ?? string.Empty
                        ));
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro de SQL na busca de Pets. Query: {comando}", "ERRO DE CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception($"Falha na consulta SQL de pets.", ex);
                }
            }
            return pets;
        }

        private (int id, string nome) BuscarClientePorCPF(string cpf)
        {
            string comando = "SELECT id_cliente, nome_cliente FROM cliente WHERE cpf_cliente = @cpf LIMIT 1";

            using (var conn = conexao.GetConnection())
            using (var cmd = new MySqlCommand(comando, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id_cliente"]);
                            string nome = reader["nome_cliente"].ToString();
                            return (id, nome);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao buscar cliente por CPF: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return (0, string.Empty);
        }

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

        // --- CARREGAMENTO DE EDIÇÃO E OPERAÇÕES CRUD ---

        private void CarregarDadosAgendamento(int id)
        {
            string comando = $@"
                SELECT 
                    t1.*, 
                    t1.observacao,  
                    t2.nome_cliente, 
                    t2.cpf_cliente,             
                    t3.nome_pet,
                    t3.raca_pet,                
                    t3.especie_pet,             
                    t4.nome_servico, 
                    t5.nome_profissional
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
                            DateTime dataDoBanco = DateTime.Parse(reader["data_agendamento"].ToString());
                            txtDia.Text = dataDoBanco.ToString("dd/MM/yyyy");
                            txtHora.Text = reader["horario"].ToString();
                            txtAgendaCliente.Text = reader["nome_cliente"].ToString();
                            txtProfissional.Text = reader["nome_profissional"].ToString();
                            txtServico.Text = reader["nome_servico"].ToString();

                            int obsIndex = reader.GetOrdinal("observacao");
                            txtObservacao.Text = reader.IsDBNull(obsIndex) ? string.Empty : reader.GetString(obsIndex);

                            // Preenche o CPF que dispara o evento txtCpf_TextChanged e carrega os pets.
                            txtCpf.Text = reader["cpf_cliente"].ToString();

                            string nomePetAgenda = reader["nome_pet"].ToString();
                            cmbPet.Text = nomePetAgenda;

                            txtRaca.Text = reader["raca_pet"] as string ?? string.Empty;
                            txtEspecie.Text = reader["especie_pet"] as string ?? string.Empty;
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

        private void ExecutarAtualizarAgendamento()
        {
            string observacao = txtObservacao.Text;
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
            string statusAgenda = "CONFIRMADO";
            string statusDia = "OCUPADO";

            string cpfLimpo = txtCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();
            int idCliente = BuscarClientePorCPF(cpfLimpo).id;

            int idPet = 0;
            if (cmbPet.SelectedItem is string nomePetSelecionado)
            {
                var petSelecionado = _petsDoCliente.Find(p => p.Nome == nomePetSelecionado);
                idPet = petSelecionado.Id;
            }

            int idProfissional = GetIdPeloNome("profissional", "id_profissional", "nome_profissional", txtProfissional.Text);
            int idServico = GetIdPeloNome("servico", "id_servico", "nome_servico", txtServico.Text);

            if (idCliente == 0 || idPet == 0 || idProfissional == 0 || idServico == 0)
            {
                MessageBox.Show("Um ou mais campos (Cliente/Pet/Profissional/Serviço) são obrigatórios ou inválidos.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = conexao.GetConnection())
            {
                string comando = @"
                    UPDATE agenda_vet SET 
                        id_cliente = @cliente, id_pet = @pet, id_profissional = @profissional, 
                        id_servico = @servico, horario = @hora, data_agendamento = @dia, 
                        status_agenda_vet = @statusAgenda, status_dia_horario_agenda_vet = @statusDia,
                        observacao = @observacao  
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
                        cmd.Parameters.AddWithValue("@observacao", observacao);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string observacao = txtObservacao.Text;
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
            string statusAgenda = "CONFIRMADO";
            string statusDia = "OCUPADO";

            string cpfLimpo = txtCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();
            int idCliente = BuscarClientePorCPF(cpfLimpo).id;

            int idPet = 0;
            if (cmbPet.SelectedItem is string nomePetSelecionado)
            {
                var petSelecionado = _petsDoCliente.Find(p => p.Nome == nomePetSelecionado);
                idPet = petSelecionado.Id;
            }

            int idProfissional = GetIdPeloNome("profissional", "id_profissional", "nome_profissional", txtProfissional.Text);
            int idServico = GetIdPeloNome("servico", "id_servico", "nome_servico", txtServico.Text);

            if (idCliente == 0 || idPet == 0 || idProfissional == 0 || idServico == 0)
            {
                MessageBox.Show("Um ou mais campos (Cliente/Pet/Profissional/Serviço) são obrigatórios ou inválidos.", "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = conexao.GetConnection())
            {
                string comando = $@"
                        INSERT INTO agenda_vet (
                                 id_cliente, id_pet, id_profissional, id_servico, horario, data_agendamento, 
                                 status_agenda_vet, status_dia_horario_agenda_vet, observacao
                        ) 
                        VALUES (
                                 @cliente, @pet, @profissional, @servico, 
                                 @hora, @dia, @statusAgenda, @statusDia, @observacao
                        )";
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
                        cmd.Parameters.AddWithValue("@observacao", observacao);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string comando = $@"DELETE FROM agenda_vet WHERE id_agenda_vet = @idExclusao";
                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@idExclusao", _idAgendamentoParaEdicao);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Agendamento excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}