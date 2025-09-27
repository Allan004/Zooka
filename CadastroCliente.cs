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
            string nome = txtnome.Text;
            string cpf = txtcpf.Text;
            string telefone = txttelefone.Text;
            string rg = txtrg.Text;
            string email = txtemail.Text;
            string cep = txtcep.Text;
            string datanascimento = txtdata.Text;
            string genero = comboBox1.Text;
            string bairro = txtbairro.Text;
            string logradouro = txtlogradouro.Text;
            string cidade = txtcidade.Text;
            string estado = txtestado.Text;

        }
    }
}
