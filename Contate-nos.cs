using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private void Contate_nos_Load(object sender, EventArgs e)
        {

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
                await EnviarEmailConfirmacaoAsync(novoemail, novonome, novotelefone);

                MessageBox.Show(
                    "Informações validadas com sucesso! O e-mail de confirmação foi enviado.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== MÉTODO CORRIGIDO ======================
        private async Task EnviarEmailConfirmacaoAsync(string emailDestino, string nome, string telefone)
        {
            // ⚠️ Use o MESMO e-mail que você usou para gerar a senha de app
            string remetente = "ZookaPetshop@gmail.com";
            string senha = "qvwppccjasjlvbefc"; // sem espaços!
            string assunto = "Confirmação de Contato - Zooka";
            string corpo = $"Olá {nome},\n\n" +
                           $"Recebemos seu contato!\n\n" +
                           $"📧 E-mail: {emailDestino}\n" +
                           $"📱 Telefone: {telefone}\n\n" +
                           $"Em breve entraremos em contato.\n\n" +
                           $"Atenciosamente,\nEquipe Zooka 🐾";

            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(remetente, senha);

                    using (var mensagem = new MailMessage())
                    {
                        mensagem.From = new MailAddress(remetente, "Equipe Zooka");
                        mensagem.To.Add(emailDestino);
                        mensagem.Subject = assunto;
                        mensagem.Body = corpo;
                        mensagem.SubjectEncoding = Encoding.UTF8;
                        mensagem.BodyEncoding = Encoding.UTF8;
                        mensagem.IsBodyHtml = false;

                        
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                        await smtp.SendMailAsync(mensagem);
                    }
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Erro SMTP ({ex.StatusCode}): {ex.Message}", "Erro SMTP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
