using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Windows.Forms;

namespace Zooka
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            UsuarioRepository usuarioRepo = new UsuarioRepository();

            bool loginValido = usuarioRepo.ValidarLogin(login, senha);

            if (loginValido)
            {
                MessageBox.Show("Bem-vindo à família Zooka!", "Login bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Revise os campos e tente novamente.", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario formCadastro = new CadastroUsuario();
            formCadastro.Show();
            this.Close();
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            // Pode adicionar código de inicialização aqui, se necessário
        }
    }

    public class Conexao
    {
        private string connectionString = "server=10.37.44.26;user id=root;password=root;database=Zooka";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

    public class UsuarioRepository
    {
        public bool ValidarLogin(string login, string senha)
        {
            try
            {
                Conexao conexao = new Conexao();

                using (var conn = conexao.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM usuario WHERE login_usuario = @login AND senha_usuario = @senha";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }
        
        }

    }

