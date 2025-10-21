using MySql.Data.MySqlClient;

namespace Zooka
{
    public partial class CadastroServico : Form
    {
        consulta_cliente teste = new consulta_cliente();
        public CadastroServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            bool formularioValido = true;

            using (var conn = conexao.GetConnection())
            {
                string nomeServico = txtNome.Text;
                string valorServico = txtPreco.Text;
                string tempoServico= txtTempo.Text;
                string categoriaServico = cmbCategoria.Text;
                string descricaoServico = txtDescricao.Text;

                if (formularioValido == true)
                {
                    string comando = "INSERT INTO servico (nome_servico,valor_servico,tempo,categoria,descricao) " +
                        "VALUES (@nomeServico,@valorServico,@tempoServico,@categoriaServico,@descricaoServico)";

                    using (var cmd = new MySqlCommand(comando, conn))

                    {
                        cmd.Parameters.AddWithValue("@nomeServico", nomeServico);
                        cmd.Parameters.AddWithValue("@valorServico", valorServico);
                        cmd.Parameters.AddWithValue("@tempoServico", tempoServico);
                        cmd.Parameters.AddWithValue("@categoriaServico", categoriaServico);
                        cmd.Parameters.AddWithValue("@descricaoServico", descricaoServico);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Concluido!!!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    teste.Limpeza(this);
                }
            }
        }
    }

}




