using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ResetarSenha : Form
    {
        private string loginUsuario;
        private bool isProfissional;

        public ResetarSenha(string login, bool profissional = false)
        {
            InitializeComponent();
            loginUsuario = login;
            isProfissional = profissional;

            btnSalvarSenha.Click += BtnSalvarSenha_Click;
        }

        private void BtnSalvarSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtASenha.Text.Trim();
            string confirmarSenha = txtASenhaC.Text.Trim();

            if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE profissional SET senha_profissional = @senha, senha_temporaria = @temp  WHERE login_profissional = @login";




                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@senha", novaSenha);
                        cmd.Parameters.AddWithValue("@login", loginUsuario);
                        cmd.Parameters.AddWithValue("@temp", 0);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 main = new Form1();
                    main.usarioo = loginUsuario;
                    main.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        string email = txtASenha.Text;
            //        string novaSenha = txtASenhaC.Text;

            //        string query = "UPDATE profissional SET senha_profissional = @senha WHERE email = @Email";

            //        using (MySqlConnection conexao = new Conexao().GetConnection())
            //        {
            //            conexao.Open();
            //            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            //            {
            //                cmd.Parameters.AddWithValue("@senha", novaSenha);
            //                cmd.Parameters.AddWithValue("@Email", email);
            //                cmd.ExecuteNonQuery();
            //            }
            //        }

            //        MessageBox.Show("Senha atualizada com sucesso!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Erro no banco de dados: " + ex.Message);
            //    }
        }

        private void ResetarSenha_Load(object sender, EventArgs e)
        {

        }
        bool controle = true;
        private void mostrarSenhaUm_CheckedChanged(object sender, EventArgs e)
        {


            if (controle == true)
            {


                txtASenha.UseSystemPasswordChar = true;
                
                controle = false;
            }
            else
            {


                txtASenha.UseSystemPasswordChar = false;
                
                controle = true;
            }
        }
        bool controle1 = true;
        private void MostarSenhaDois_CheckedChanged(object sender, EventArgs e)
        {
            if (controle1 == true)
            {


                
                txtASenhaC.UseSystemPasswordChar = true;
                controle = false;
            }
            else
            {


               
                txtASenhaC.UseSystemPasswordChar = false;
                controle = true;
            }
        }
    }
}
