using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            
        }

       

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string novonome = txtNome.Text.Trim();
            string novoemail = txtEmail.Text.Trim();
            string novasenha = txtSenha.Text.Trim();


            using (var conn = conexao.GetConnection())

            {
                //conn.Open();

                // faça os comandos CRUD normalmente


               

                string comando = "INSERT INTO usuario (nome_usuario, email_usuario, senha_usuario) VALUES (@nome, @email, @senha)";


                using (var cmd = new MySqlCommand(comando, conn))

                {

                    cmd.Parameters.AddWithValue("@nome", novonome);

                    cmd.Parameters.AddWithValue("@email", novoemail);

                    cmd.Parameters.AddWithValue("@senha", novasenha);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }


           

            if (string.IsNullOrEmpty(novonome) || string.IsNullOrEmpty(novoemail) || string.IsNullOrEmpty(novasenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Nome: {novonome}\n" +
                $"Email: {novoemail}\n" +
                $"Senha: {novasenha}\n",
                "Dados Cadastrados",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
