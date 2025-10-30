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
    public partial class Precos : Form
    {
        public Precos()
        {
            InitializeComponent();
        }

       
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Login_B = new LoginUsuario();
            Login_B.Show();
            this.Close();
        }
    }
}
