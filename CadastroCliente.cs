using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class CadastroCliente : Form
    {
        consulta_cliente teste = new consulta_cliente();
        public CadastroCliente()
        {
            InitializeComponent();

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();

            bool veri = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show($"O campo '{txt.Name.Replace("txt", "")}' está vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return;
                }

            }


            using (var conn = conexao.GetConnection())
            {
                string novonome = txtnome.Text;
                string novocpf = txtcpf.Text.Replace(",", "").Replace("-", "");
                string novotelefone = txttelefone.Text.Replace(",", "").Replace("(", "").Replace(")", "").Replace("-", "");
                string novorg = txtrg.Text.Replace(",", "").Replace("-", "");
                string novoemail = txtemail.Text;
                string novocep = txtcep.Text.Replace(",", "").Replace("-", "");
                string novodatanascimento = txtdata.Text;
                string novogenero = comboBox1.Text;
                string novobairro = txtbairro.Text;
                string novologradouro = txtlogradouro.Text;
                string novocidade = txtcidade.Text;
                string novoestado = txtestado.Text;

                string comando = "INSERT INTO cliente (nome_cliente,genero,cpf_cliente,rg_cliente,nascimento_cliente,telefone_cliente,email_cliente,cep_cliente,logradouro_cliente,bairro_cliente,cidade_cliente,estado_cliente) " +
                    "VALUES (@nome,@genero,@cpf,@rg,STR_TO_DATE(@nascimento, '%d/%m/%Y'),@telefone,@email,@cep,@logradouro,@bairro,@cidade,@estado)";

                DataRow[] vericpf = teste.InsertGeral("cliente").Select($"cpf_cliente = '{novocpf}'");
                DataRow[] verirg = teste.InsertGeral("cliente").Select($"rg_cliente = '{novorg}'");

                if (vericpf.Length > 0)
                {
                    errorProvider1.SetError(txtcpf, "CPF ja Cadastrado");
                    veri = false;
                }
                if (verirg.Length > 0)
                {
                    errorProvider1.SetError(txtrg, "RG ja Cadastrado");
                    veri = false;
                }


                if (veri == true)
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
                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Concluido!!!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    teste.Limpeza(this);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

