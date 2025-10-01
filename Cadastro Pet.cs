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
using System.Xml.Linq;

namespace Zooka
{
    public partial class Cadastro_Pet : Form
    {
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


            using (var conn = conexao.GetConnection())
            {
                string novonome = txtnomepet.Text;
                string novorg = txtrganimal.Text.Replace(",", "").Replace("-", "");
                string novoespecie = comboEspecie.Text;
                string novoraca = boxRaca.Text;
                int novoidade = Convert.ToInt32(txtIdade.Text);
                decimal novopeso = Convert.ToDecimal(txt_Peso.Text);
                string novopelagem = txtPelagem.Text;
                string novosexo = boxSexo.Text;
                string cpf = txtcpfcliente.Text.Replace(",", "").Replace("-", "");
                int idcliente = 0;

                
                string sql = "SELECT * FROM cliente WHERE cpf_cliente Like @cpf";
                
                
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                    {
                        
                        da.SelectCommand.Parameters.AddWithValue("@cpf", $"%{cpf}%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        idcliente = Convert.ToInt32(dt.Rows[0]["id_cliente"]);
                    }
                

                string comando = "INSERT INTO pet (sexo_pet,rg_pet raca_pet,peso_pet,pelagem_pet,nome_pet,idade_pet,id_cliente,especie_pet) " +
                    "VALUES (@sexo,@rg,@raca,@peso,@pelagem,@nome,@idade,@idcliente,@especie)";


                using (var cmd = new MySqlCommand(comando, conn))

                {

                    cmd.Parameters.AddWithValue("@nome", novonome);

                    cmd.Parameters.AddWithValue("@sexo",novosexo);

                    cmd.Parameters.AddWithValue("@raca",novoraca );

                    cmd.Parameters.AddWithValue("@peso", novopeso);

                    cmd.Parameters.AddWithValue("@pelagem",novopelagem );

                    cmd.Parameters.AddWithValue("@idade",novoidade );

                    cmd.Parameters.AddWithValue("@idcliente", idcliente);

                    cmd.Parameters.AddWithValue("@especie",novoespecie );

                    cmd.Parameters.AddWithValue("@rg", novorg);

                   

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
    }
}
