using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class CadastroProfissional : Form
    {
        consulta_cliente limpa = new consulta_cliente();

        public CadastroProfissional()
        {
            InitializeComponent();
        }

        private void CadastroProfissional_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            bool veri = true;

            // Validação de campos obrigatórios
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show($"O campo '{txt.Name.Replace("txt", "")}' está vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return;
                }
            }

            errorProvider1.Clear();

            using (var conn = conexao.GetConnection())
            {
                string novonome = txtnome.Text.Trim();
                string novocpf = txtcpf.Text.Replace(",", "").Replace("-", "").Trim();
                string novotelefone = txttelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                string novorg = txtrg.Text.Replace(",", "").Replace("-", "").Trim();
                string novoemail = txtemail.Text.Trim();
                string novocep = txtcep.Text.Replace("-", "").Trim();
                string novodatanascimento = txtdata.Text.Trim();
                string novogenero = comboBox1.Text;
                string novobairro = txtbairro.Text.Trim();
                string novologradouro = txtlogradouro.Text.Trim();
                string novocidade = txtcidade.Text.Trim();
                string novoestado = txtestado.Text.Trim();
                string novoespecializacao = textBox1.Text.Trim();

                // 🔍 Verificação extra para o CEP
                if (novocep.Length > 10)
                {
                    MessageBox.Show("CEP inválido! Verifique o valor digitado.", "Erro no CEP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Geração automática de login e senha
                string loginGerado = novonome.Split(' ')[0].ToLower() + novocpf.Substring(0, 3);
                string novasenha = "zooka@" + DateTime.Now.Ticks.ToString().Substring(10);

                string comando = @"INSERT INTO profissional 
                        (nome_profissional, genero_profissional, cpf_profissional, rg_profissional, data_nasc_profissional,
                         telefone_profissional, email_profissional, cep_profissional, logradouro_profissional,
                         bairro_profissional, cidade_profissional, estado_profissional, especializacao_profissional,
                         login_profissional, senha_profissional)
                         VALUES (@nome, @genero, @cpf, @rg, STR_TO_DATE(@nascimento, '%d/%m/%Y'),
                         @telefone, @email, @cep, @logradouro, @bairro, @cidade, @estado, 
                         @especialidade, @login, @senha)";


                // Verificação de duplicidade
                DataRow[] vericpf = limpa.InsertGeral("profissional").Select($"cpf_profissional = '{novocpf}'");
                DataRow[] verirg = limpa.InsertGeral("profissional").Select($"rg_profissional = '{novorg}'");

                if (vericpf.Length > 0)
                {
                    errorProvider1.SetError(txtcpf, "CPF já cadastrado");
                    veri = false;
                }
                if (verirg.Length > 0)
                {
                    errorProvider1.SetError(txtrg, "RG já cadastrado");
                    veri = false;
                }

                if (veri)
                {
                    try
                    {
                        using (var cmd = new MySqlCommand(comando, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome", novonome);
                            cmd.Parameters.AddWithValue("@genero", novogenero);
                            cmd.Parameters.AddWithValue("@cpf", novocpf);
                            cmd.Parameters.AddWithValue("@rg", novorg);
                            cmd.Parameters.AddWithValue("@nascimento", novodatanascimento);
                            cmd.Parameters.AddWithValue("@telefone", novotelefone);
                            cmd.Parameters.AddWithValue("@email", novoemail);
                            cmd.Parameters.AddWithValue("@cep", novocep);
                            cmd.Parameters.AddWithValue("@logradouro", novologradouro);
                            cmd.Parameters.AddWithValue("@bairro", novobairro);
                            cmd.Parameters.AddWithValue("@cidade", novocidade);
                            cmd.Parameters.AddWithValue("@estado", novoestado);
                            cmd.Parameters.AddWithValue("@especialidade", novoespecializacao);

                            // ⚠️ Estes dois estavam faltando:
                            cmd.Parameters.AddWithValue("@login", loginGerado);
                            cmd.Parameters.AddWithValue("@senha", novasenha);

                            conn.Open();
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            if (linhasAfetadas > 0)
                            {
                                await EnviarEmailConfirmacaoAsync(novoemail, novonome, loginGerado, novasenha);

                                MessageBox.Show(
                                    $"Usuário cadastrado com sucesso!\n\nLogin: {loginGerado}\nEmail: {novoemail}",
                                    "Cadastro realizado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                limpa.Limpeza(this);
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma linha foi inserida. Verifique o comando SQL.",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro durante o cadastro:\n" + ex.ToString(),
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        //parte de enviar o email da vitoria
        private async Task EnviarEmailConfirmacaoAsync(string emailDestino, string nome, string loginGerado, string senhaGerada)
        {
            string remetente = "ZookaPetshop@gmail.com";
            string senha = "foyn xvnq tnyg zoqq"; // senha de app do Gmail
            string assunto = "Confirmação de Cadastro - Zooka 🐾";

            string corpo = $"Olá {nome},\n\n" +
                           $"Seu cadastro como profissional foi concluído com sucesso!\n\n" +
                           $"🧾 Login: {loginGerado}\n" +
                           $"🔑 Senha: {senhaGerada}\n" +
                           $"📧 E-mail: {emailDestino}\n\n" +
                           $"Bem-vindo à equipe Zooka Petshop! 🐶✨\n\n" +
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

        private void button1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtcidade_TextChanged(object sender, EventArgs e) { }
        private void txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }

        private void txtdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
