using Org.BouncyCastle.Math.Field;
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
    public partial class Consulta : Form
    {
        consulta_cliente teste = new consulta_cliente();


        public string defineForms { get; set; }



        public Consulta()
        {

            InitializeComponent();
            dtgCliente.DefaultCellStyle.ForeColor = Color.Black;
            dtgCliente.DefaultCellStyle.BackColor = Color.White;

        }




        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgCliente.CurrentRow != null)
            {
                string id = Convert.ToString(dtgCliente.SelectedRows[0].Cells["id_cliente"].Value);


                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    teste.ExcluirLinha("cliente", "id_cliente", id);
                    dtgCliente.Refresh();

                }
                else
                {
                    MessageBox.Show("Selecione um produto para remover.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            dtgCliente.DataSource = teste.InsertGeral(defineForms);
        }
    }
}