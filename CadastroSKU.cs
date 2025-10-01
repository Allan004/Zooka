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

            // MOSTRAR PRÓXIMO ID AO CARREGAR O FORM
            AtualizarProximoID();
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
            string sql = "INSERT INTO produto (nome_produto, udm_produto, tipo_estoque) " +
                "VALUES (@nomeproduto, @udm, @tipoestoque)";

            try
            {
                using (var conn = new MySqlConnection(connStr))
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nomeproduto", txtSKU_descricao.Text);
                    cmd.Parameters.AddWithValue("@udm", cbSKU_udm.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tipoestoque", cbSKU_estoque.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("SKU criado com sucesso!");

                // LIMPAR CAMPOS PARA O PRÓXIMO CADASTRO
                txtSKU_descricao.Clear();
                cbSKU_udm.SelectedIndex = -1;
                cbSKU_estoque.SelectedIndex = -1;

                AtualizarProximoID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar SKU: " + ex.Message);
            }
        }

        private void btnSKU_search_Click_1(object sender, EventArgs e)
        {
            searchSKU searchForm = new searchSKU();
            searchForm.ShowDialog();
        }
    }
}
