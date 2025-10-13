using MySql.Data.MySqlClient;
using SisVendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooka
{
    class consulta_cliente
    {

        public DataTable Verificarcpf(string padrao)
        {
            string defi = padrao;
            string sql =  "SELECT * FROM cliente WHERE cpf_cliente Like @cpf";
            Conexao conexao = new Conexao();
            using (var conn = conexao.GetConnection())
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@cpf", $"%{defi}%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }




        }
        public void Limpeza(Control controle)
        {

            foreach (Control c in controle.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;

                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;

                else if (c is ListBox)
                    ((ListBox)c).ClearSelected();

                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now;
                
                else if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();

               
            }
        }

      
        


    }

    }
    

