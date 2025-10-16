using MySql.Data.MySqlClient;
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
using System.Xml.Linq;
using System.CodeDom;

namespace Zooka
{
    public partial class Cadastro_Pet : Form
    {
        consulta_cliente teste = new consulta_cliente();
        public Cadastro_Pet()
        {
            InitializeComponent();
        }

        private void Cadastro_Pet_Load(object sender, EventArgs e)
        {

        }

        private void txtlogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show($"O campo '{txt.Name.Replace("txt", "")}' está vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt.Focus();
                    return;
                }
            }
            bool formularioValido = true;


            errorProvider1.Clear();






            using (var conn = conexao.GetConnection())
            {

                string novonome = txtnomepet.Text;
                string novorg = txtrganimal.Text.Replace(",", "").Replace("-", "");
                string novoespecie = comboEspecie.Text;
                string novoraca = boxRaca.Text;
                int novoidade = 0;
                decimal novopeso = 0;
                string novopelagem = txtPelagem.Text;
                string novosexo = boxSexo.Text;
                int cpf = 0;
                try
                {
                    cpf = Convert.ToInt32(teste.Verificarcpf(txtcpfcliente.Text.Replace(",", "").Replace("-", "")).Rows[0]["id_cliente"]);
                }
                catch
                {
                    errorProvider1.SetError(txtcpfcliente, "Digite um Cpf Valido");
                    formularioValido = false;
                }

                if (string.IsNullOrEmpty(txtnomepet.Text))
                {
                    errorProvider1.SetError(txtnomepet, "O Campo nome é obrigatorio");
                    formularioValido = false;
                }
                if (!int.TryParse(txtIdade.Text, out novoidade))
                {
                    errorProvider1.SetError(txtIdade, "O Campo Idade so aceita Numeros");
                    formularioValido = false;
                }
                if (!decimal.TryParse(txt_Peso.Text, out novopeso))
                {
                    errorProvider1.SetError(txt_Peso, "O Campo Peso so Aceita Numero inteiro e duas casas Decimais");
                    formularioValido = false;
                }


                if (formularioValido == true)
                {
                    string comando = "INSERT INTO pet (sexo_pet,rg_pet,raca_pet,peso_pet,pelagem_pet,nome_pet,idade_pet,id_cliente,especie_pet) " +
                        "VALUES (@sexo,@rg,@raca,@peso,@pelagem,@nome,@idade,@idcliente,@especie)";




                    using (var cmd = new MySqlCommand(comando, conn))

                    {
                        cmd.Parameters.AddWithValue("@nome", novonome);
                        cmd.Parameters.AddWithValue("@sexo", novosexo);
                        cmd.Parameters.AddWithValue("@raca", novoraca);
                        cmd.Parameters.AddWithValue("@pelagem", novopelagem);
                        cmd.Parameters.AddWithValue("@idcliente", cpf);
                        cmd.Parameters.AddWithValue("@peso", novopeso);
                        cmd.Parameters.AddWithValue("@idade", novoidade);
                        cmd.Parameters.AddWithValue("@rg", novorg);
                        cmd.Parameters.AddWithValue("@especie", novoespecie);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Concluido!!!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    teste.Limpeza(this);
                }
            }



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void boxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}




