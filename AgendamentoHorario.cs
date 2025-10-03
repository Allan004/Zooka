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
        consulta_cliente conulta = new consulta_cliente();
        Conexao conexao = new Conexao();
        public AgendamentoHorario()
        {
            InitializeComponent();
        }

        private void AgendamentoHorario_Load(object sender, EventArgs e)
        {
            txtDia.Text = Agenda.static_ano  + "-" + Agenda.static_mes + "-" + ControlAgendaDias.static_dia;
            txtHora.Text = Agenda.static_hora.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           

            using (var conn = conexao.GetConnection())
            {
                string dia = txtDia.Text;
                string hora = txtHora.Text;
                string statusAgenda = txtStatus.Text;
                string statusDia = txtStatusDia.Text;
                string cliente = txtAgendaCliente.Text;
                string pet = txtPet.Text;
                string profissional = txtProfissional.Text;
                string servico = txtServico.Text;


                string comando = "INSERT INTO agenda_vet (id_cliente,id_pet,id_profissional,id_servico, horario, data_agendamento, status_agenda_vet, status_dia_horario_agenda_vet) " +
                                 "VALUES (@cliente, @pet, @profissional, @servico, @hora, @dia,  @statusAgenda, @statusDia)";


                using (var cmd = new MySqlCommand(comando, conn))

                {
                    cmd.Parameters.AddWithValue("@dia", dia);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@statusAgenda", statusAgenda);
                    cmd.Parameters.AddWithValue("@statusDia", statusDia);
                    cmd.Parameters.AddWithValue("@cliente", cliente);
                    cmd.Parameters.AddWithValue("@pet", pet);
                    cmd.Parameters.AddWithValue("@profissional", profissional);
                    cmd.Parameters.AddWithValue("@servico", servico);


                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Salvou");
                }
            }
        }
    }
}
