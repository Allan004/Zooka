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
                string nomeFantasia = txtNomeFantasia.Text;
                string nomeRazaoSocial = txtRazaoSocial.Text;
                string cnpj = txtCNPJ.Text;
                string categoriaServico = cmbCategoria.Text;
                string descricaoServico = txtDescricao.Text;

                if (formularioValido == true)
                {
                    string comando = "INSERT INTO servico (nome_servico,valor_servico,tempo,categoria,descricao) " +
                        "VALUES (@nomeServico,@valorServico,@tempoServico,@categoriaServico,@descricaoServico)";

                    using (var cmd = new MySqlCommand(comando, conn))

                    {
                        cmd.Parameters.AddWithValue("@nomeServico", nomeFantasia);
                        cmd.Parameters.AddWithValue("@valorServico", nomeRazaoSocial);
                        cmd.Parameters.AddWithValue("@tempoServico", cnpj);
                        cmd.Parameters.AddWithValue("@categoriaServico", categoriaServico);
                        cmd.Parameters.AddWithValue("@descricaoServico", descricaoServico);

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
    }
}
