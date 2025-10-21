using MySql.Data.MySqlClient;
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

            this.Load += CadastroUsuario_Load;
            this.chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            this.chkMostrarConfirmarSenha.CheckedChanged += chkMostrarConfirmarSenha_CheckedChanged;

            CarregarCombos();
        }

        private void CarregarCombos()
        {

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.UseSystemPasswordChar = true;
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

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void chkMostrarConfirmarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarConfirmarSenha.Checked;
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
                mensagem.Subject = "🎉 Cadastro realizado com sucesso!";
                mensagem.IsBodyHtml = true;


                string corpoHtml = $@"
<!DOCTYPE html>
<html lang='pt-BR'>
<head>
    <meta charset='UTF-8'>
</head>
<body style='margin: 0; padding: 0; background-color: #f2f6fa; font-family: Arial, sans-serif;'>

    <div style='max-width: 600px; margin: 30px auto; background-color: #ffffff; border-radius: 8px; overflow: hidden; box-shadow: 0 2px 8px rgba(0,0,0,0.05);'>

     
        <img src='https://i.imgur.com/XIHRKrO.png' alt='ZooKa Petshop' style='width: 100%; display: block;' />

       
        <div style='padding: 30px; color: #333333;'>

            <h2 style='color: #4B0082; margin-top: 0;'>🐾 Olá, {nomeUsuario}!</h2>

            <p style='font-size: 16px; line-height: 1.6;'>
                🎉 Seu cadastro na <strong>ZooKa Petshop</strong> foi realizado com sucesso!
            </p>

            <p style='font-size: 16px; line-height: 1.6;'>
                Seja muito bem-vindo(a) à nossa família apaixonada por pets! Aqui, o cuidado e o carinho com os seus melhores amigos vêm sempre em primeiro lugar. 🐶🐱
            </p>

          
            <div style='background-color: #f9f9f9; padding: 15px; border-radius: 6px; margin: 25px 0; font-size: 16px;'>
                <p><strong>👤 Login:</strong> {login}<br>
                <strong>🔒 Senha:</strong> {senha}</p>
            </div>

            <p style='font-size: 16px;'>✨ Guarde essas informações com carinho e segurança.</p>

            
            <p style='font-size: 16px;'>
                🎁 Como forma de agradecimento, preparamos um presente especial para você:
            </p>

            <p style='font-size: 16px;'>
                <strong>15% de desconto exclusivo</strong> na sua primeira compra!<br />
                Use o código <strong style='color: #4B0082;'>ZOOKA15</strong> no checkout para aproveitar. 🛒
            </p>

            <p style='font-size: 14px; color: #666;'>Com carinho,<br>
            🐾 Equipe ZooKa Petshop</p>
        </div>

      
        <div style='background-color: #eeeeee; padding: 15px; text-align: center; font-size: 14px; color: #777777;'>
            Siga-nos nas redes sociais:<br />
            <strong>@ZooKaPetshop's</strong> no Instagram, Facebook e X
        </div>
    </div>
</body>
</html>";


                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(corpoHtml, null, "text/html");
                mensagem.AlternateViews.Add(htmlView);


                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("zookapetshop@gmail.com", "qcep rhha qovq sehn");
                    await smtp.SendMailAsync(mensagem);
                }
            }
        }

        private void chkMostrarConfirmarSenha_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkMostrarSenha_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
