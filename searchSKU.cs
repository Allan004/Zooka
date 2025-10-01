using MySql.Data.MySqlClient;
using SisVendas;
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
        public searchSKU()
        {
            InitializeComponent();
        }

        private void searchSKU_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
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
                    dgvSKU_search.AutoGenerateColumns = false;
                    dgvSKU_search.Columns.Clear();
                    dgvSKU_search.RowHeadersVisible = false;
                    dgvSKU_search.AllowUserToResizeRows = false;
                    dgvSKU_search.RowTemplate.Height = 24;

                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "id_skuproduto",
                        HeaderText = "ID",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "nome_produto",
                        HeaderText = "Produto",
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
                        HeaderText = "Tipo Estoque",
                        ReadOnly = true
                    });
                    dgvSKU_search.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Status",
                        HeaderText = "Status",
                        ReadOnly = true
                    });

                    dgvSKU_search.DataSource = dt;
                    dgvSKU_search.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar SKUs: " + ex.Message);
            }
        }
    }
}