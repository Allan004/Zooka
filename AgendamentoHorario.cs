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
            txtDia.Text = Agenda.static_ano + "- " + Agenda.static_mes + "-" + ControlAgendaDias.static_dia;
        }


    }
}
