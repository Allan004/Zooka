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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            string casa = null;
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


            using (var conn = conexao.GetConnection())
            {
                string novonome = txtnome.Text;
                string novocpf = txtcpf.Text.Replace(",","").Replace("-","");
                string novotelefone = txttelefone.Text.Replace(",","").Replace("(","").Replace(")","");
                string novorg = txtrg.Text.Replace(",", "").Replace("-", "");
                string novoemail = txtemail.Text;
                string novocep = txtcep.Text.Replace(",", "").Replace("-", "");
                string novodatanascimento = txtdata.Text.Replace("/","-");
                string novogenero = comboBox1.Text;
                string novobairro = txtbairro.Text;
                string novologradouro = txtlogradouro.Text;
                string novocidade = txtcidade.Text;
                string novoestado = txtestado.Text;

                string comando = "INSERT INTO cliente (nome_cliente,genero,cpf_cliente,rg_cliente,nascimento_cliente,telefone_cliente,email_cliente,cep_cliente,logradouro_cliente,bairro_cliente,cidade_cliente,estado_cliente) " +
                    "VALUES (@nome,@genero,@cpf,@rg,@nascimento,@telefone,@email,@cep,@logradouro,@bairro,@cidade,@estado)";


                using (var cmd = new MySqlCommand(comando, conn))

                {

                    cmd.Parameters.AddWithValue("@nome", novonome);

                    cmd.Parameters.AddWithValue("@genero",novogenero);

                    cmd.Parameters.AddWithValue("@cpf", novocpf);

                    cmd.Parameters.AddWithValue("@rg", novorg);

                    cmd.Parameters.AddWithValue("@nascimento",novodatanascimento);

                    cmd.Parameters.AddWithValue("@telefone", novotelefone);

                    cmd.Parameters.AddWithValue("@email", novoemail);

                    cmd.Parameters.AddWithValue("@cep",novocep);

                    cmd.Parameters.AddWithValue("@logradouro", novologradouro);

                    cmd.Parameters.AddWithValue("@bairro", novobairro);

                    cmd.Parameters.AddWithValue("@cidade", novocidade);

                    cmd.Parameters.AddWithValue("@estado", novoestado);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
