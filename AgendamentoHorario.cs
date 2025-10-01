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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zooka
{
    public partial class AgendamentoHorario : Form
    {
        Conexao conexao = new Conexao();
        public AgendamentoHorario()
        {
            InitializeComponent();
        }

        private void AgendamentoHorario_Load(object sender, EventArgs e)
        {
            txtDia.Text = Agenda.static_ano + "-" + Agenda.static_mes + "-" + ControlAgendaDias.static_dia;
            txtHora.Text = Agenda.static_hora.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           

            using (var conn = conexao.GetConnection())
            {
                string dia = txtDia.Text;
                string evento = txtEvento.Text;


                string comando = "INSERT INTO produto (nome_produto, udm_produto) VALUES (@dias, @eventos)";


                using (var cmd = new MySqlCommand(comando, conn))

                {
                    cmd.Parameters.AddWithValue("@dias", dia);

                    cmd.Parameters.AddWithValue("@eventos", evento);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Salvou");
                }
            }
        }
    }
}
