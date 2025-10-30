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

            // Agora pega 3 valores da função: loginValido, isProfissional e senhaTemporaria
            var resultado = UsuarioRepository.ValidarLoginTipo(login, senha);
            bool loginValido = resultado.Item1;
            bool isProfissional = resultado.Item2;
            bool senhaTemporaria = resultado.Item3;

            if (loginValido)
            {
                if (senhaTemporaria)
                {
                    MessageBox.Show("Login bem-sucedido! Redefina sua senha.",
                        "Zooka PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarSenha telaReset = new ResetarSenha(login, isProfissional);
                    telaReset.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login bem-sucedido! Bem-vindo(a) ao sistema.",
                        "Zooka PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 menu = new Form1();
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Revise os campos e tente novamente.",
                    "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // =============================== CONEXÃO COM O BANCO ===============================
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            "server=10.37.44.26;user id=root;password=root;database=zooka;SslMode=Disabled;AllowPublicKeyRetrieval=True;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

    // ============================= LOGIN VALIDATION =============================
    public static class UsuarioRepository
    {
        // Retorna (loginValido, isProfissional, senhaTemporaria)
        public static (bool, bool, bool) ValidarLoginTipo(string login, string senha)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Verifica login de usuário comum
                    string queryUsuario = @"SELECT senha_temporaria 
                                            FROM usuario 
                                            WHERE login_usuario = @login 
                                            AND senha_usuario = @senha";
                    using (var cmd = new MySqlCommand(queryUsuario, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            bool senhaTemp = Convert.ToBoolean(result);
                            return (true, false, senhaTemp);
                        }
                    }

                    // Verifica login de profissional
                    string queryProfissional = @"SELECT senha_temporaria 
                                                 FROM profissional 
                                                 WHERE login_profissional = @login 
                                                 AND senha_profissional = @senha";
                    using (var cmd = new MySqlCommand(queryProfissional, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            bool senhaTemp = Convert.ToBoolean(result);
                            return (true, true, senhaTemp);
                        }
                    }

                    return (false, false, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, false, false);
            }
        }
    }
}
