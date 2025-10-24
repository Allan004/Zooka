using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class searchSKU : Form
    {
        public int SelecionadoID { get; set; }
        public string SelecionadoNome { get; set; }

        private DataTable dtOriginal;

        public searchSKU()
        {
            InitializeComponent();
        }

        private void searchSKU_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            txtSKUCad_search.TextChanged += txtSKUCad_search_TextChanged;

        }
        private void txtSKUCad_search_TextChanged(object sender, EventArgs e)
        {
            if (dtOriginal == null) return;

            string filtro = txtSKUCad_search.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtro))
            {
                dgvSKU_search.DataSource = dtOriginal;
                return;
            }

            DataView dv = new DataView(dtOriginal);
            dv.RowFilter = $"nome_produto LIKE '%{filtro}%' OR Convert(id_skuproduto, 'System.String') LIKE '%{filtro}%'";
            dgvSKU_search.DataSource = dv;
        }

        private void dgvSKU_search_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) // HEADER
            {

                using (SolidBrush brush = new SolidBrush(Color.MidnightBlue))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                // FORMATAÇÃO
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString(),
                    new Font("Segoe UI", 10, FontStyle.Bold),
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
                using (Pen pen = new Pen(Color.White, 1))
                {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 1;
                    rect.Height -= 1;
                    e.Graphics.DrawRectangle(pen, rect);
                }

                e.Handled = true;
            }
        }
        private void CarregarProdutos()
        {
            string sql = @"SELECT id_skuproduto, nome_produto, udm_produto, tipo_estoque, 
                          IF(status_sku = b'1', 1, 0) AS status_sku_numeric
                   FROM produto";

            try
            {
                using (var conn = new MySqlConnection(Conexao.connString))
                using (var cmd = new MySqlCommand(sql, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (!dt.Columns.Contains("Status"))
                        dt.Columns.Add("Status", typeof(string));

                    foreach (DataRow row in dt.Rows)
                    {
                        int statusInt = 0;
                        if (row["status_sku_numeric"] != DBNull.Value)
                            statusInt = Convert.ToInt32(row["status_sku_numeric"]);

                        row["Status"] = statusInt == 1 ? "ATIVO" : "DESATIVADO";
                    }

                    // CONFIGURAÇÃO DATAGRIDVIEW
                    dtOriginal = dt;
                    dgvSKU_search.AutoGenerateColumns = false;
                    dgvSKU_search.Columns.Clear();
                    dgvSKU_search.RowHeadersVisible = false;
                    dgvSKU_search.AllowUserToResizeRows = false;
                    dgvSKU_search.RowTemplate.Height = 24;
                    dgvSKU_search.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvSKU_search.MultiSelect = false;
                    dgvSKU_search.EnableHeadersVisualStyles = false;
                    dgvSKU_search.CellPainting += dgvSKU_search_CellPainting;

                    // ESTILO DO HEADER
                    dgvSKU_search.EnableHeadersVisualStyles = false;
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "id_skuproduto",
                        DataPropertyName = "id_skuproduto",
                        HeaderText = "SKU",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "nome_produto",
                        HeaderText = "PRODUTO",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "udm_produto",
                        HeaderText = "UDM",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "tipo_estoque",
                        HeaderText = "ESTOQUE",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        Name = "Status",
                        DataPropertyName = "Status",
                        HeaderText = "STATUS",
                        ReadOnly = true
                    });

                    dgvSKU_search.DataSource = dtOriginal;
                    dgvSKU_search.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar SKUs: " + ex.Message);
            }
        }

        // BOTÃO DE SEARCH FUNCIONAL, PORÉM NÃO VOU UTILIZÁ-LO NESSA OCASIÃO

        //private void btnSKUCad_search_Click(object sender, EventArgs e)

        //{
        //    string filtro = txtSKUCad_search.Text.Trim().ToLower();

        //    if (dtOriginal == null) return;

        //    // SEARCH FILTRADO
        //    DataView dv = new DataView(dtOriginal);
        //    dv.RowFilter = $"nome_produto LIKE '%{filtro}%' OR Convert(id_skuproduto, 'System.String') LIKE '%{filtro}%'";
        //    dgvSKU_search.DataSource = dv;

        //}

        private void btnSKU_des_atv_Click(object sender, EventArgs e)
        {
            if (dgvSKU_search.SelectedRows.Count == 0) return;

            // LINHA SELECIONADA AO CLICAR
            DataGridViewRow linha = dgvSKU_search.SelectedRows[0];

            int idProduto = Convert.ToInt32(linha.Cells["id_skuproduto"].Value);

            // LÊ O STATUS ATUAL (APENAS NO GRID)
            string statusAtual = linha.Cells["Status"].Value.ToString();

            // CONVERTE PARA BOOLEAN
            int novoStatusDb = (statusAtual == "ATIVO") ? 0 : 1;

            // TRADUZ O NÚMERO E EXIBE O NOVO STATUS NO GRID
            string novoStatusTexto = novoStatusDb == 1 ? "ATIVO" : "DESATIVADO";

            try
            {
                using (var conn = new MySqlConnection(Conexao.connString))
                using (var cmd = new MySqlCommand("UPDATE produto SET status_sku = @novoStatus WHERE id_skuproduto = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@novoStatus", novoStatusDb);
                    cmd.Parameters.AddWithValue("@id", idProduto);

                    conn.Open();
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        // ATUALIZA A COLUNA STATUS
                        linha.Cells["Status"].Value = novoStatusTexto;
                        MessageBox.Show("Status atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha foi atualizada. Verifique o ID do produto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar status: " + ex.Message);
            }
        }

        private void btnSKU_editar_Click(object sender, EventArgs e)
        {
            if (dgvSKU_search.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um SKU para editar.");
                return;
            }

            int idProduto = Convert.ToInt32(dgvSKU_search.SelectedRows[0].Cells["id_skuproduto"].Value);

            CadastroSKU form = new CadastroSKU(idProduto);
            form.ShowDialog();

            CarregarProdutos(); // ATUALIZA O GRID
        }

        private void btnCriarSku_Search_Click(object sender, EventArgs e)
        {
            CadastroSKU cadastroSKU = new CadastroSKU();
            cadastroSKU.ShowDialog();
        }
    }

}