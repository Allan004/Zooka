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

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();


            using (var conn = conexao.GetConnection())
            {
                string novonome = txtnome.Text;
                string novocpf = txtcpf.Text.Replace(",", "").Replace("-", "");
                string novotelefone = txttelefone.Text.Replace(",", "").Replace("(", "").Replace(")", "");
                string novorg = txtrg.Text.Replace(",", "").Replace("-", "");
                string novoemail = txtemail.Text;
                string novocep = txtcep.Text.Replace(",", "").Replace("-", "");
                string novodatanascimento = txtdata.Text;
                string novogenero = comboBox1.Text;
                string novobairro = txtbairro.Text;
                string novologradouro = txtlogradouro.Text;
                string novocidade = txtcidade.Text;
                string novoestado = txtestado.Text;
                string novoespecializacao = textBox1.Text;

                string comando = "INSERT INTO profissional (nome_profissional,genero_profissional,cpf_profissional,rg_profissional,data_nasc_profissional,telefone_profissional,email_profissional,cep_profissional,logradouro_profissional,bairro_profissional,cidade_profissional,estado_profissional,especializacao_profissional) " +
                    "VALUES (@nome,@genero,@cpf,@rg,STR_TO_DATE(@nascimento, '%d/%m/%Y'),@telefone,@email,@cep,@logradouro,@bairro,@cidade,@estado,@especialidade)";


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
                    cmd.Parameters.AddWithValue("especialidade", novoespecializacao);
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    limpa.Limpeza(this);


                }
            }


        }
    }
}
