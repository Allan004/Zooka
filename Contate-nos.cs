using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // necessário para abrir WhatsApp

namespace Zooka
{
    public partial class Contate_nos : Form
    {
        public Contate_nos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var PaginaInicial_B = new PaginaInicial();
            PaginaInicial_B.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Precos_B = new Precos();
            Precos_B.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Login_C = new LoginUsuario();
            Login_C.Show();
            this.Close();
        }

        private async void BtnEntrar_Click(object sender, EventArgs e)
        {
            string novonome = SeuNome.Text.Trim();
            string novoemail = SeuEmail.Text.Trim();
            string novotelefone = SeuTelefone.Text.Trim();

            if (string.IsNullOrEmpty(novonome) || string.IsNullOrEmpty(novoemail) || string.IsNullOrEmpty(novotelefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!novonome.Contains(" "))
            {
                MessageBox.Show("Por favor, informe nome e sobrenome.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var addr = new MailAddress(novoemail);
            }
            catch
            {
                MessageBox.Show("E-mail inválido. Por favor, verifique o formato.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string telefoneLimpo = Regex.Replace(novotelefone, "[^0-9]", "");
            if (telefoneLimpo.Length < 10 || telefoneLimpo.Length > 11)
            {
                MessageBox.Show("Número de telefone inválido. Use o formato (DDD) 99999-9999.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Para enviar o email para o usuario cadastrado
                await EnviarEmailConfirmacaoAsync(novoemail, novonome, novotelefone);

                // Esse aqui abre o whatsap
                string mensagemWhatsApp = $"Olá! Gostaria de saber mais sobre os serviços da Zooka Petshop 🐶✨";
                AbrirWhatsAppComNumero(novotelefone, mensagemWhatsApp);

                MessageBox.Show(
                    "Informações validadas com sucesso! O e-mail de confirmação foi enviado e o WhatsApp foi aberto.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar a confirmação: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task EnviarEmailConfirmacaoAsync(string emailDestino, string nome, string telefone)
        {
            string remetente = "ZookaPetshop@gmail.com";
            string senha = "foyn xvnq tnyg zoqq"; //Senha do nosso email zooka
            string assunto = "Confirmação de Contato - Zooka 🐾";
            string corpo = $"Olá {nome},\n\n" +
                           $"Recebemos seu contato!\n\n" +
                           $"📧 E-mail: {emailDestino}\n" +
                           $"📱 Telefone: {telefone}\n\n" +
                           $"Em breve entraremos em contato.\n\n" +
                           $"Atenciosamente,\nEquipe Zooka 🐾";

            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente, senha);
                smtp.EnableSsl = true;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (var mensagem = new MailMessage())
                {
                    mensagem.From = new MailAddress(remetente, "Equipe Zooka 🐾");
                    mensagem.To.Add(emailDestino);
                    mensagem.Subject = assunto;
                    mensagem.Body = corpo;
                    mensagem.SubjectEncoding = Encoding.UTF8;
                    mensagem.BodyEncoding = Encoding.UTF8;
                    mensagem.IsBodyHtml = false;

                    await smtp.SendMailAsync(mensagem);
                }
            }
        }

        // NOVA FUNÇÃO: ele  abre WhatsApp com número e mensagem
        private void AbrirWhatsAppComNumero(string rawNumber, string mensagemOpcional = null)
        {
            string onlyDigits = Regex.Replace(rawNumber ?? "", @"\D", "");
            if (string.IsNullOrEmpty(onlyDigits))
            {
                MessageBox.Show("Telefone inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            onlyDigits = onlyDigits.TrimStart('0');
            if (!onlyDigits.StartsWith("55")) onlyDigits = "55" + onlyDigits;

            string waNumber = onlyDigits;
            string encodedMsg = string.IsNullOrEmpty(mensagemOpcional) ? "" : $"?text={Uri.EscapeDataString(mensagemOpcional)}";
            string url = $"https://wa.me/{waNumber}{encodedMsg}";

            try
            {
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o WhatsApp: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Contate_nos_Load(object sender, EventArgs e)
        {

        }
    }
}
