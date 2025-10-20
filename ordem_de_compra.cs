using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ordem_de_compra : Form
    {
        private Dictionary<int, string> skusCache = new Dictionary<int, string>();
        private ListBox lstSuggestions = new ListBox();
        private int editingRow = -1;

        public ordem_de_compra()
        {
            InitializeComponent();
        }

        private void ordem_de_compra_Load(object sender, EventArgs e)
        {
            // Configura TextBox OC
            txtNumeroOC.Enabled = false;
            txtNumeroOC.BackColor = Color.White;
            txtNumeroOC.ForeColor = Color.Black;
            txtNumeroOC.TabStop = false;

            // Número OC
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

            // Carrega SKUs do banco
            CarregarSKUsDoBanco();

            // Configura grid e lista suspensa
            ConfigurarGrid();
            ConfigurarListaSugestoes();
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

            dgvItensOC.Columns["valorunit"].DefaultCellStyle.Format = "C2";
            dgvItensOC.Columns["valortotal"].DefaultCellStyle.Format = "C2";
            dgvItensOC.Columns["valortotal"].ReadOnly = true;

            dgvItensOC.CellBeginEdit += dgvItensOC_CellBeginEdit;
            dgvItensOC.CellEndEdit += dgvItensOC_CellEndEdit;
        }

        private void ConfigurarListaSugestoes()
        {
            lstSuggestions.Visible = false;
            lstSuggestions.Font = dgvItensOC.Font;
            lstSuggestions.Click += LstSuggestions_Click;
            this.Controls.Add(lstSuggestions);
        }

        private void dgvItensOC_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0 || dgvItensOC.Columns[e.ColumnIndex].Name != "produto")
            {
                lstSuggestions.Visible = false;
                return;
            }

            editingRow = e.RowIndex;
            AtualizarSugestoes(dgvItensOC.Rows[e.RowIndex].Cells["produto"].Value?.ToString() ?? "");
        }

        private void AtualizarSugestoes(string texto)
        {
            lstSuggestions.Items.Clear();
            if (string.IsNullOrEmpty(texto)) { lstSuggestions.Visible = false; return; }

            foreach (var kv in skusCache)
            {
                if (kv.Key.ToString().Contains(texto) || kv.Value.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                    lstSuggestions.Items.Add($"{kv.Key} - {kv.Value}");
            }

            if (lstSuggestions.Items.Count > 0)
            {
                var rect = dgvItensOC.GetCellDisplayRectangle(dgvItensOC.Columns["produto"].Index, editingRow, true);
                lstSuggestions.SetBounds(dgvItensOC.PointToScreen(rect.Location).X - this.Left,
                                         dgvItensOC.PointToScreen(rect.Location).Y - this.Top + rect.Height,
                                         rect.Width, Math.Min(100, lstSuggestions.Items.Count * 20));
                lstSuggestions.Visible = true;
                lstSuggestions.BringToFront();
            }
            else
            {
                lstSuggestions.Visible = false;
            }
        }

        private void LstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem == null || editingRow < 0) return;
            var parts = lstSuggestions.SelectedItem.ToString().Split(new string[] { " - " }, StringSplitOptions.None);
            dgvItensOC.Rows[editingRow].Cells["id_skuproduto"].Value = parts[0];
            dgvItensOC.Rows[editingRow].Cells["produto"].Value = parts[1];
            lstSuggestions.Visible = false;
        }

        private void dgvItensOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            lstSuggestions.Visible = false;

            var row = dgvItensOC.Rows[e.RowIndex];
            if (double.TryParse(Convert.ToString(row.Cells["quantidade"].Value), out double qtd) &&
                double.TryParse(Convert.ToString(row.Cells["valorunit"].Value), out double valorUnit))
            {
                row.Cells["valortotal"].Value = qtd * valorUnit;
            }

            AtualizarTotalGeral();
        }

        private void AtualizarTotalGeral()
        {
            double totalGeral = 0;
            foreach (DataGridViewRow row in dgvItensOC.Rows)
            {
                if (row.IsNewRow) continue;
                if (double.TryParse(Convert.ToString(row.Cells["valortotal"].Value), out double valor))
                    totalGeral += valor;
            }
            lblTotalOC.Text = totalGeral.ToString("C2");
        }
    }
}