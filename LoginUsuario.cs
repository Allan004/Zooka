using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Zooka
{
    public partial class LoginUsuario : Form
    {
        Form1 recebe = new Form1();
        public LoginUsuario()
        {
            InitializeComponent();
            this.Load += LoginUsuario_Load;
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            if (this.txtSenha != null)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void senhaLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtSenha != null && sender is CheckBox chk)
            {
                txtSenha.UseSystemPasswordChar = !chk.Checked;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin?.Text ?? string.Empty;
            string senha = txtSenha?.Text ?? string.Empty;

            bool loginValido = UsuarioRepository.ValidarLogin(login, senha);

            if (loginValido)
            {
                MessageBox.Show("Bem-vindo à família Zooka!", "Login bem-sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recebe.usarioo = txtLogin.Text;
                recebe.Show();
                this.Hide();


                // aqui você pode abrir o form principal e fechar o login, por exemplo

            }
            else
            {
                MessageBox.Show("Revise os campos e tente novamente.", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formCadastro = new CadastroUsuario();
            formCadastro.Show();
            this.Close();
        }

        private void LoginUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void SenhaLogin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sender is CheckBox chk)
            {
                txtSenha.UseSystemPasswordChar = !chk.Checked;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }

    public class DatabaseConnection
    {
        private static readonly string connectionString = "server=10.37.44.26;user id=root;password=root;database=Zooka";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

    public class UsuarioRepository
    {
        public static bool ValidarLogin(string login, string senha)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Primeiro tenta login de usuário normal
                    string queryUsuario = "SELECT COUNT(*) FROM usuario WHERE login_usuario = @login AND senha_usuario = @senha";
                    using (var cmd = new MySqlCommand(queryUsuario, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int countUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                        if (countUsuario > 0)
                        {
                            return true; // login de usuário comum válido
                        }
                    }

                    // Se não encontrou usuário, tenta profissional
                    string queryProfissional = "SELECT COUNT(*) FROM profissional WHERE login_profissional = @login AND senha_profissional = @senha";
                    using (var cmd = new MySqlCommand(queryProfissional, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int countProfissional = Convert.ToInt32(cmd.ExecuteScalar());

                        return countProfissional > 0; // retorna true se for profissional
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
