using MySql.Data.MySqlClient;


namespace Zooka
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            bool formularioValido = true;

            using (var conn = conexao.GetConnection())
            {
                string nomeFantasiaFornecedor = txtNomeFantasia.Text;
                string nomeRazaoSocialFornecedor = txtRazaoSocial.Text;
                string cnpjFornecedor = txtCNPJ.Text;
                string emailFornecedor = txtEmail.Text;
                string telefoneFornecedor = txtTelefone.Text;
                string telefoneRepresentanteFornecedor = txtTelefoneRepresentante.Text;
                string cepFornecedor = txtCep.Text;
                string ruaFornecedor = txtRua.Text;
                string numeroEnderecoFornecedor = txtNumeroEndereco.Text;
                string bairroFornecedor = txtBairro.Text;
                string cidadeFornecedor = txtCidade.Text;
                string estadoFornecedor = txtEstado.Text;
                string complementoFornecedor = txtComplemento.Text;
                string statusFornecedor = "";
                string segmentoFornecedor  = cmbSegmento.Text;

                if (rdbAtivo.Checked)
                {
                    statusFornecedor = "Ativo";
                }
                else if (rdbInativo.Checked)
                {
                    statusFornecedor = "Inativo";
                }


                if (formularioValido == true)
                {
                    string comando =$@" 
                        INSERT INTO fornecedor (
                                 nomefantasia_fornecedor, razaosocial_fornecedor, cnpj_fornecedor, 
                                 email_fornecedor, telefone_fornecedor, contato_fornecedor, cep,
                                 rua_fornecedor, numero_fornecedor, bairro_fornecedor,
                                 cidade_fornecedor, estado_fornecedor, complemento_fornecedor,
                                 status_fornecedor, segmento_fornecedor 
                        ) 
                        VALUES (
                                 @nomeFantasia,@nomeRazaoSocial,@cnpj,
                                 @email,@telefone,@telefoneRepresentante,@cep,
                                 @rua,@numero,@bairro,@cidade,
                                 @estado,@complemento,@statusFornecedor,@segmentoFornecedor
                        )";

                    using (var cmd = new MySqlCommand(comando, conn))

                    {
                        cmd.Parameters.AddWithValue("@nomeFantasia", nomeFantasiaFornecedor);
                        cmd.Parameters.AddWithValue("@nomeRazaoSocial", nomeRazaoSocialFornecedor);
                        cmd.Parameters.AddWithValue("@cnpj", cnpjFornecedor);
                        cmd.Parameters.AddWithValue("@email", emailFornecedor);
                        cmd.Parameters.AddWithValue("@telefone", telefoneFornecedor);
                        cmd.Parameters.AddWithValue("@telefoneRepresentante", telefoneRepresentanteFornecedor);
                        cmd.Parameters.AddWithValue("@cep", cepFornecedor);
                        cmd.Parameters.AddWithValue("@rua", ruaFornecedor);
                        cmd.Parameters.AddWithValue("@numero", numeroEnderecoFornecedor);
                        cmd.Parameters.AddWithValue("@bairro", bairroFornecedor);
                        cmd.Parameters.AddWithValue("@cidade", cidadeFornecedor);
                        cmd.Parameters.AddWithValue("@estado", estadoFornecedor);
                        cmd.Parameters.AddWithValue("@complemento", complementoFornecedor);
                        cmd.Parameters.AddWithValue("@statusFornecedor", statusFornecedor);
                        cmd.Parameters.AddWithValue("@segmentoFornecedor", segmentoFornecedor);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Concluido!!!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
