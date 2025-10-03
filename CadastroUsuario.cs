using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            // Preencher combos se necessário
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
        }

        private async void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string novonome = txtNome.Text.Trim();
            string novoemail = txtEmail.Text.Trim();
            string novasenha = txtSenha.Text.Trim();
            string confirmarSenha = txtConfirmarSenha.Text.Trim();

            if (string.IsNullOrEmpty(novonome) || string.IsNullOrEmpty(novoemail) ||
                string.IsNullOrEmpty(novasenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novasenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Por favor, digite novamente.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var addr = new MailAddress(novoemail);
            }
            catch
            {
                MessageBox.Show("E-mail inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loginGerado = await GerarLoginUnicoAsync(novonome);

            try
            {
                Conexao conexao = new Conexao();
                using (var conn = conexao.GetConnection())
                {
                    conn.Open();

                    string comandoUsuario = "INSERT INTO usuario (nome_usuario, email_usuario, senha_usuario, login_usuario) " +
                                            "VALUES (@nome, @email, @senha, @login)";

                    using (var cmd = new MySqlCommand(comandoUsuario, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", novonome);
                        cmd.Parameters.AddWithValue("@email", novoemail);
                        cmd.Parameters.AddWithValue("@senha", novasenha);
                        cmd.Parameters.AddWithValue("@login", loginGerado);

                        cmd.ExecuteNonQuery();
                    }
                }

                await EnviarEmailConfirmacaoAsync(novoemail, novonome, loginGerado, novasenha);

                MessageBox.Show(
                    $"Usuário cadastrado com sucesso!\n\nLogin: {loginGerado}\nEmail: {novoemail}",
                    "Cadastro realizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante o cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GerarLoginUnicoAsync(string nome)
        {
            string baseLogin = nome.ToLower().Replace(" ", "");
            string loginGerado = baseLogin;
            int contador = 1;

            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                await conn.OpenAsync();

                while (true)
                {
                    string comando = "SELECT COUNT(*) FROM usuario WHERE login_usuario = @login";
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@login", loginGerado);

                        long existe = (long)await cmd.ExecuteScalarAsync();

                        if (existe == 0)
                        {
                            return loginGerado;
                        }

                        loginGerado = baseLogin + contador.ToString();
                        contador++;
                    }
                }
            }
        }

        private async Task EnviarEmailConfirmacaoAsync(string emailDestino, string nomeUsuario, string login, string senha)
        {
            using (var mensagem = new MailMessage())
            {
                mensagem.From = new MailAddress("zookapetshop@gmail.com", "ZooKa Petshop");
                mensagem.To.Add(emailDestino);
                mensagem.Subject = "Cadastro realizado com sucesso!";
                mensagem.Body = $@"
Olá {nomeUsuario},

Seu cadastro foi concluído com sucesso!

Aqui estão seus dados de acesso:

Login: {login}
Senha: {senha}

Guarde essas informações com segurança.

Você também ganhou 10% de desconto na sua primeira compra! Use o código BEMVINDO10 no checkout.

Com carinho,
Equipe ZooKa Petshop";

                mensagem.IsBodyHtml = false;

                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("zookapetshop@gmail.com", "qcep rhha qovq sehn");
                    await smtp.SendMailAsync(mensagem);
                }
            }
        }
    }
}
