using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Zooka
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
            this.Load += LoginUsuario_Load;
           
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = UsuarioRepository.ValidarLoginTipo(login, senha);
            bool loginValido = resultado.Item1;
            bool isProfissional = resultado.Item2;

            if (loginValido)
            {
                MessageBox.Show("Login bem-sucedido! Redefina sua senha.",
                    "Zooka PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre o formulário de redefinição de senha
                ResetarSenha telaReset = new ResetarSenha(login, isProfissional);
                telaReset.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise os campos e tente novamente.",
                    "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // =============================== CONEXÃO COM O BANCO ===============================
    public class DatabaseConnection
    {
        private static readonly string connectionString =
            "server=10.37.44.26;user id=root;password=root;database=Zooka";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

    // ============================= LOGIN VALIDATION =============================
    public class UsuarioRepository
    {
        // Retorna (loginValido, isProfissional)
        public static (bool, bool) ValidarLoginTipo(string login, string senha)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Verifica login de usuário comum
                    string queryUsuario = "SELECT COUNT(*) FROM usuario WHERE login_usuario = @login AND senha_usuario = @senha";
                    using (var cmd = new MySqlCommand(queryUsuario, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        int countUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                        if (countUsuario > 0)
                            return (true, false); // É usuário comum
                    }

                    // Verifica login de profissional
                    string queryProfissional = "SELECT COUNT(*) FROM profissional WHERE login_profissional = @login AND senha_profissional = @senha";
                    using (var cmd = new MySqlCommand(queryProfissional, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        int countProfissional = Convert.ToInt32(cmd.ExecuteScalar());

                        if (countProfissional > 0)
                            return (true, true); // É profissional
                    }

                    return (false, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, false);
            }
        }
    }
}
