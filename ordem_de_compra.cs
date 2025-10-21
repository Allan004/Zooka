using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ordem_de_compra : Form
    {
        private Dictionary<int, string> skusCache = new Dictionary<int, string>();
        private ListBox lstSuggestions = new ListBox();
        private int editingRow = -1;
        private TextBox currentEditingTextBox = null;

        public ordem_de_compra()
        {
            InitializeComponent();
        }

        private void ordem_de_compra_Load(object sender, EventArgs e)
        {
            txtNumeroOC.Enabled = false;
            txtNumeroOC.BackColor = Color.White;
            txtNumeroOC.ForeColor = Color.Black;
            txtNumeroOC.TabStop = false;

            // Impedir o usuário de mover/arrastar colunas
            dgvItensOC.AllowUserToOrderColumns = false;

            // Impedir que o usuário redimensione colunas e linhas manualmente
            dgvItensOC.AllowUserToResizeColumns = false;
            dgvItensOC.AllowUserToResizeRows = false;

            // Ajustar o tamanho das colunas automaticamente conforme o conteúdo
            dgvItensOC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // (Opcional) Ajusta o tamanho das linhas também
            dgvItensOC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MAX(id_oc) FROM ordem_de_compra";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int proximoID = (result == null || result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;
                    txtNumeroOC.Text = proximoID.ToString();
                }
            }

            txtDataOC.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // CARREGA SKUs
            CarregarSKUsDoBanco();

            ConfigurarGrid();
            ConfigurarListaSugestoes();
            CarregarFormasPagamento();

            // --> ADICIONADO: recalcular total sempre que o frete mudar
            txtFreteOC.TextChanged += (s, ev) => AtualizarTotalGeral();
            txtFreteOC.Leave += (s, ev) => AtualizarTotalGeral();
        }
        private void CarregarFormasPagamento()
        {
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT id_fpagamento, forma_pagamento FROM forma_pagamento ORDER BY id_fpagamento";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbPagamentoOC.DataSource = dt;
                    cbPagamentoOC.DisplayMember = "forma_pagamento"; // o que aparece no ComboBox
                    cbPagamentoOC.ValueMember = "id_fpagamento";     // o valor real
                    cbPagamentoOC.SelectedIndex = -1;               // começa vazio
                }
            }
        }

        private void CarregarSKUsDoBanco()
        {
            skusCache.Clear();
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT id_skuproduto, nome_produto FROM produto ORDER BY nome_produto";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id_skuproduto"]);
                        string nome = reader["nome_produto"].ToString();
                        skusCache[id] = nome;
                    }
                }
            }
        }

        private void ConfigurarGrid()
        {
            dgvItensOC.Columns.Clear();
            dgvItensOC.AllowUserToAddRows = true;
            dgvItensOC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensOC.RowHeadersVisible = false;

            dgvItensOC.Columns.Add("id_skuproduto", "ID SKU");
            dgvItensOC.Columns.Add("produto", "Produto");
            dgvItensOC.Columns.Add("quantidade", "Qtd");
            dgvItensOC.Columns.Add("valorunit", "Valor Unitário");
            dgvItensOC.Columns.Add("valortotal", "Valor Total");


            dgvItensOC.Columns["id_skuproduto"].FillWeight = 60;
            dgvItensOC.Columns["produto"].FillWeight = 220;
            dgvItensOC.Columns["quantidade"].FillWeight = 70;
            dgvItensOC.Columns["valorunit"].FillWeight = 90;
            dgvItensOC.Columns["valortotal"].FillWeight = 90;

            dgvItensOC.AllowUserToOrderColumns = false;
            dgvItensOC.AllowUserToResizeColumns = false;
            dgvItensOC.AllowUserToResizeRows = false;

            dgvItensOC.Columns["valorunit"].DefaultCellStyle.Format = "C2";
            dgvItensOC.Columns["valortotal"].DefaultCellStyle.Format = "C2";
            dgvItensOC.Columns["valortotal"].ReadOnly = true;

            dgvItensOC.EditingControlShowing += DgvItensOC_EditingControlShowing;
            dgvItensOC.CellEndEdit += dgvItensOC_CellEndEdit;
        }

        private void ConfigurarListaSugestoes()
        {
            lstSuggestions.Visible = false;
            lstSuggestions.Font = dgvItensOC.Font;
            lstSuggestions.IntegralHeight = false;

            dgvItensOC.Controls.Add(lstSuggestions);

            lstSuggestions.Click += (s, e) => SelecionarSugestaoAtual();
            lstSuggestions.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SelecionarSugestaoAtual();
                    e.Handled = true;
                }
            };
        }

        private void DgvItensOC_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvItensOC.CurrentCell.OwningColumn.Name == "produto")
            {
                currentEditingTextBox = e.Control as TextBox;
                if (currentEditingTextBox != null)
                {
                    currentEditingTextBox.TextChanged -= ProdutoTextChanged;
                    currentEditingTextBox.TextChanged += ProdutoTextChanged;
                    editingRow = dgvItensOC.CurrentCell.RowIndex;
                }
            }
        }

        private void ProdutoTextChanged(object sender, EventArgs e)
        {
            if (currentEditingTextBox == null) return;
            string texto = currentEditingTextBox.Text;
            AtualizarSugestoes(texto);
        }

        private void AtualizarSugestoes(string texto)
        {
            lstSuggestions.Items.Clear();
            if (string.IsNullOrEmpty(texto))
            {
                lstSuggestions.Visible = false;
                return;
            }

            var resultados = skusCache
                .Where(kv => kv.Value.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(kv => kv.Value)
                .ToList();

            foreach (var nome in resultados) lstSuggestions.Items.Add(nome);

            if (lstSuggestions.Items.Count > 0)
            {
                var rect = dgvItensOC.GetCellDisplayRectangle(dgvItensOC.Columns["produto"].Index, editingRow, true);
                lstSuggestions.SetBounds(
                    rect.X,
                    rect.Y + rect.Height,
                    rect.Width,
                    Math.Min(120, lstSuggestions.Items.Count * 20)
                );
                lstSuggestions.Visible = true;
                lstSuggestions.BringToFront();
            }
            else
            {
                lstSuggestions.Visible = false;
            }
        }

        private void SelecionarSugestaoAtual()
        {
            if (lstSuggestions.SelectedItem == null || editingRow < 0) return;
            string nomeSelecionado = lstSuggestions.SelectedItem.ToString().Trim();
            if (string.IsNullOrEmpty(nomeSelecionado)) return;

            var match = skusCache
                .FirstOrDefault(kv => string.Equals(kv.Value?.Trim(), nomeSelecionado, StringComparison.OrdinalIgnoreCase));

            if (match.Equals(default(KeyValuePair<int, string>)))
            {
                match = skusCache
                    .FirstOrDefault(kv => kv.Value != null && kv.Value.IndexOf(nomeSelecionado, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (match.Equals(default(KeyValuePair<int, string>)))
            {
                dgvItensOC.Rows[editingRow].Cells["produto"].Value = nomeSelecionado;
                lstSuggestions.Visible = false;
                return;
            }

            dgvItensOC.Rows[editingRow].Cells["id_skuproduto"].Value = match.Key;
            dgvItensOC.Rows[editingRow].Cells["produto"].Value = match.Value;

            if (currentEditingTextBox != null)
            {
                currentEditingTextBox.Text = match.Value;
                currentEditingTextBox.SelectionStart = currentEditingTextBox.Text.Length;
                currentEditingTextBox.Focus();
            }

            lstSuggestions.Visible = false;
        }

        private void dgvItensOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lstSuggestions.Visible = false;
            var row = dgvItensOC.Rows[e.RowIndex];

            var culture = new CultureInfo("pt-BR");
            double qtd = 0, valorUnit = 0;

            if (row.Cells["quantidade"].Value != null)
            {
                double.TryParse(Convert.ToString(row.Cells["quantidade"].Value), NumberStyles.Any, culture, out qtd);
            }

            if (row.Cells["valorunit"].Value != null)
            {
                // aceita "R$ 1.234,56" ou "1234,56" ou "1234.56"
                if (!double.TryParse(Convert.ToString(row.Cells["valorunit"].Value), NumberStyles.Any, culture, out valorUnit))
                {
                    string s = Convert.ToString(row.Cells["valorunit"].Value)
                        .Replace("R$", "")
                        .Replace(" ", "")
                        .Replace(".", "")
                        .Replace(",", ".");
                    double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out valorUnit);
                }
            }

            double totalLinha = qtd * valorUnit;
            row.Cells["valortotal"].Value = totalLinha;

            AtualizarTotalGeral();
        }

        private void AtualizarTotalGeral()
        {
            double totalGeral = 0;
            var culture = new CultureInfo("pt-BR");

            foreach (DataGridViewRow row in dgvItensOC.Rows)
            {
                if (row.IsNewRow) continue;
                var cel = row.Cells["valortotal"].Value;
                if (cel == null) continue;

                double valor = 0;
                if (!double.TryParse(Convert.ToString(cel), NumberStyles.Any, culture, out valor))
                {
                    string s = Convert.ToString(cel).Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
                    double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out valor);
                }

                totalGeral += valor;
            }

            if (!string.IsNullOrWhiteSpace(txtFreteOC.Text))
            {
                double frete = 0;
                if (!double.TryParse(txtFreteOC.Text, NumberStyles.Any, culture, out frete))
                {
                    string s = txtFreteOC.Text.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
                    double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out frete);
                }
                totalGeral += frete;
            }

            lblTotalOC.Text = totalGeral.ToString("C2", culture);
        }

        private void btnSalvarOC_Click(object sender, EventArgs e)
        {
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";

            var culture = new System.Globalization.CultureInfo("pt-BR");

            string nomeFornecedor = txtFornecedor_oc.Text.Trim();
            if (string.IsNullOrEmpty(nomeFornecedor))
            {
                txtFornecedor_oc.Focus();
                MessageBox.Show("Digite o nome do fornecedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeComprador = txtComprador.Text.Trim();
            if (string.IsNullOrEmpty(nomeComprador))
            {
                txtComprador.Focus();
                MessageBox.Show("Digite o nome do comprador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPagamentoOC.SelectedValue == null)
            {
                cbPagamentoOC.Focus();
                MessageBox.Show("Selecione a forma de pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idPagamento = Convert.ToInt32(cbPagamentoOC.SelectedValue);

            double frete = 0;
            if (!string.IsNullOrWhiteSpace(txtFreteOC.Text))
            {
                if (!double.TryParse(txtFreteOC.Text, System.Globalization.NumberStyles.Any, culture, out frete))
                {
                    string s = txtFreteOC.Text.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
                    if (!double.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out frete))
                    {
                        txtFreteOC.Focus();
                        MessageBox.Show("Valor do frete inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            var itensParaInserir = new List<(int idSKU, double qtd, double unit, double total)>();
            double totalGeral = 0;
            for (int i = 0; i < dgvItensOC.Rows.Count; i++)
            {
                var row = dgvItensOC.Rows[i];
                if (row.IsNewRow) continue;

                if (row.Cells["id_skuproduto"].Value == null)
                {
                    MessageBox.Show($"Linha {i + 1}: selecione um produto (SKU).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvItensOC.CurrentCell = row.Cells["produto"];
                    return;
                }

                if (!int.TryParse(Convert.ToString(row.Cells["id_skuproduto"].Value), out int idSKU))
                {
                    MessageBox.Show($"Linha {i + 1}: ID do SKU inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvItensOC.CurrentCell = row.Cells["produto"];
                    return;
                }

                double qtd = 0;
                if (row.Cells["quantidade"].Value != null)
                {
                    double.TryParse(Convert.ToString(row.Cells["quantidade"].Value), System.Globalization.NumberStyles.Any, culture, out qtd);
                }

                double unit = 0;
                if (row.Cells["valorunit"].Value != null)
                {
                    var rawUnit = Convert.ToString(row.Cells["valorunit"].Value);
                    if (!double.TryParse(rawUnit, System.Globalization.NumberStyles.Any, culture, out unit))
                    {
                        string s = rawUnit.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
                        double.TryParse(s, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out unit);
                    }
                }

                double totalLinha = qtd * unit;
                itensParaInserir.Add((idSKU, qtd, unit, totalLinha));
                totalGeral += totalLinha;
            }

            totalGeral += frete;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlTransaction trans = null;
                try
                {
                    trans = conn.BeginTransaction();

                    int idFornecedor = 0;
                    string sqlFornecedor = "SELECT id_fornecedor FROM fornecedor WHERE nomefantasia_fornecedor = @nome LIMIT 1";
                    using (var cmdF = new MySqlCommand(sqlFornecedor, conn, trans))
                    {
                        cmdF.Parameters.AddWithValue("@nome", nomeFornecedor);
                        var result = cmdF.ExecuteScalar();
                        if (result != null)
                            idFornecedor = Convert.ToInt32(result);
                        else
                        {
                            throw new Exception("Fornecedor não encontrado!");
                        }
                    }

                    int idProfissional = 0;
                    string sqlProf = "SELECT id_profissional FROM profissional WHERE nome_profissional = @nome LIMIT 1";
                    using (var cmdP = new MySqlCommand(sqlProf, conn, trans))
                    {
                        cmdP.Parameters.AddWithValue("@nome", nomeComprador);
                        var result = cmdP.ExecuteScalar();
                        if (result != null)
                            idProfissional = Convert.ToInt32(result);
                        else
                            throw new Exception("Comprador não encontrado!");
                    }

                    string sqlOC = @"
                INSERT INTO ordem_de_compra 
                (id_fornecedor, valorfrete_oc, valototal_oc, id_fpagamento, data_oc, id_profissional)
                VALUES (@fornecedor, @frete, @total, @pagamento, @data, @profissional);
            ";
                    using (var cmdOC = new MySqlCommand(sqlOC, conn, trans))
                    {
                        cmdOC.Parameters.AddWithValue("@fornecedor", idFornecedor);
                        cmdOC.Parameters.AddWithValue("@frete", frete);
                        cmdOC.Parameters.AddWithValue("@total", totalGeral);
                        cmdOC.Parameters.AddWithValue("@pagamento", idPagamento);
                        cmdOC.Parameters.AddWithValue("@data", DateTime.Now);
                        cmdOC.Parameters.AddWithValue("@profissional", idProfissional);
                        cmdOC.ExecuteNonQuery();
                    }

                    long idOC;
                    using (var cmdLast = new MySqlCommand("SELECT LAST_INSERT_ID()", conn, trans))
                    {
                        idOC = Convert.ToInt64(cmdLast.ExecuteScalar());
                    }

                    string sqlItem = @"
                INSERT INTO itens_ordem_de_compra 
                (id_oc, id_skuproduto, quantidade, valorunitario, valortotal)
                VALUES (@idOC, @idSKU, @qtd, @unit, @total);
            ";
                    using (var cmdItem = new MySqlCommand(sqlItem, conn, trans))
                    {
                        foreach (var item in itensParaInserir)
                        {
                            cmdItem.Parameters.Clear();
                            cmdItem.Parameters.AddWithValue("@idOC", idOC);
                            cmdItem.Parameters.AddWithValue("@idSKU", item.idSKU);
                            cmdItem.Parameters.AddWithValue("@qtd", item.qtd);
                            cmdItem.Parameters.AddWithValue("@unit", item.unit);
                            cmdItem.Parameters.AddWithValue("@total", item.total);
                            cmdItem.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();

                    MessageBox.Show("Ordem de compra salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtFornecedor_oc.Text = "";
                    txtDataOC.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    if (int.TryParse(txtNumeroOC.Text, out int numeroAtu)) txtNumeroOC.Text = (numeroAtu + 1).ToString();

                    txtFreteOC.Text = "";
                    dgvItensOC.Rows.Clear();

                    AtualizarTotalGeral();
                    lblTotalOC.Text = (0.0).ToString("C2", culture);

                    txtComprador.Text = "";
                    cbPagamentoOC.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (trans != null && trans.Connection != null)
                            trans.Rollback();
                    }
                    catch
                    {

                    }

                    MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnCriarSKU_OC_Click(object sender, EventArgs e)
        {
            CadastroSKU cadastroSKU = new CadastroSKU();
            cadastroSKU.ShowDialog();
            CarregarSKUsDoBanco();
        }
    }
}
