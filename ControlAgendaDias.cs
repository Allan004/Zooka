using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ControlAgendaDias : UserControl
    {
        public ControlAgendaDias()
        {
            InitializeComponent();
        }

        private void ControleAgendaDias_Load(object sender, EventArgs e)
        {
        }

        public void days(int numDia)
        {
            lblDia.Text = numDia + "";
        }
    }
}
