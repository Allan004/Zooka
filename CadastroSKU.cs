using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class CadastroSKU : Form
    {
        public CadastroSKU()
        {
            InitializeComponent();
        }
        private int? idEdicao = null;
        public CadastroSKU(int idProduto)
        {
            InitializeComponent();
            idEdicao = idProduto;
        }


        private void btnSKU_search_Click(object sender, EventArgs e)
        {

        }

        private void CadastroSKU_Load(object sender, EventArgs e)
        {
            // UDM
            cbSKU_udm.Items.AddRange(new string[]
            {
                "UN","PCT","CX","M","G","KG","L"});

            // ESTOQUE
            cbSKU_estoque.Items.AddRange(new string[]
                {
                    "CONSUMO", "VENDA"});

            // DESABILITAR TEXTBOX DO ID
            txtSKU_id.Enabled = false;

            // SE FOR EDIÇÃO, CARREGA OS DADOS DO PRODUTO
            if (idEdicao.HasValue)
            {
                CarregarDadosParaEdicao(idEdicao.Value);
            }
            else
            {
                // MOSTRAR PRÓXIMO ID AO CARREGAR O FORM
                AtualizarProximoID();

            }
        }
        private void CarregarDadosParaEdicao(int id)
        {
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            string sql = "SELECT id_skuproduto, nome_produto, udm_produto, tipo_estoque FROM produto WHERE id_skuproduto = @id";

            using (var conn = new MySqlConnection(connStr))
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtSKU_id.Text = reader["id_skuproduto"].ToString();
                        txtSKU_descricao.Text = reader["nome_produto"].ToString();
                        cbSKU_udm.SelectedItem = reader["udm_produto"].ToString();
                        cbSKU_estoque.SelectedItem = reader["tipo_estoque"].ToString();
                    }
                }
            }
        }
        // FUNÇÃO PARA BUSCAR O ÚLTIMO ID E MOSTRAR O PRÓXIMO
        private void AtualizarProximoID()
        {
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT MAX(id_skuproduto) FROM produto";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int proximoID = (result == null || result == DBNull.Value)
                        ? 1
                        : Convert.ToInt32(result) + 1;
                    txtSKU_id.Text = proximoID.ToString();
                }


            }

        }

        private void btnSKU_criar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSKU_descricao.Text) ||
                    cbSKU_udm.SelectedIndex == -1 ||
                    cbSKU_estoque.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";
            string sql;

            if (idEdicao.HasValue)
            {
                // SE FOR EDIÇÃO
                sql = "UPDATE produto SET nome_produto=@nomeproduto, udm_produto=@udm, tipo_estoque=@tipoestoque WHERE id_skuproduto=@id";
            }
            else
            {
                // SE FOR NOVO
                sql = "INSERT INTO produto (nome_produto, udm_produto, tipo_estoque) " +
                      "VALUES (@nomeproduto, @udm, @tipoestoque)";
            }

            try
            {
                var idExistente = VerificarSKU(txtSKU_descricao.Text);
                if (idExistente.HasValue && !idEdicao.HasValue)
                {
                    MessageBox.Show($"Já existe um SKU com esse nome!\nID: {idExistente}",
                        "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = new MySqlConnection(connStr))
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nomeproduto", txtSKU_descricao.Text);
                    cmd.Parameters.AddWithValue("@udm", cbSKU_udm.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tipoestoque", cbSKU_estoque.SelectedItem.ToString());

                    if (idEdicao.HasValue)
                        cmd.Parameters.AddWithValue("@id", idEdicao);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(idEdicao.HasValue ? "SKU atualizado com sucesso!" : "SKU criado com sucesso!");

                if (!idEdicao.HasValue)
                {
                    // LIMPAR CAMPOS PARA O PRÓXIMO CADASTRO
                    txtSKU_descricao.Clear();
                    cbSKU_udm.SelectedIndex = -1;
                    cbSKU_estoque.SelectedIndex = -1;

                    AtualizarProximoID();
                }
                else
                {
                    // FECHAR FORM APÓS EDIÇÃO
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar SKU: " + ex.Message);
            }
        }

        private void btnSKU_search_Click_1(object sender, EventArgs e)
        {
            searchSKU searchForm = new searchSKU();
            searchForm.ShowDialog();
        }
        private int? VerificarSKU(string nomeProduto)
        {
            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT id_skuproduto FROM produto WHERE nome_produto = @nomeproduto";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nomeproduto", nomeProduto);
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            return null;
        }

    }
}
