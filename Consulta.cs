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
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;

        }

        string coluna0 = null;
        string coluna1 = null;


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = Convert.ToString(dataGridView1.SelectedRows[0].Cells["id_cliente"].Value);


                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    teste.ExcluirLinha("cliente", "id_cliente", id);
                    dataGridView1.Refresh();

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


            string filtro = textBox1.Text.Trim().Replace("'", "''");
            string coluna0 = dataGridView1.Columns[0].Name;
            string coluna1 = dataGridView1.Columns[1].Name;

            if (string.IsNullOrEmpty(filtro))
            {
                dataGridView1.DataSource = teste.InsertGeral(defineForms); ;
                return;
            }

            DataView dv = new DataView(teste.InsertGeral(defineForms));
            dv.RowFilter = $"Convert([{coluna0}], 'System.String') LIKE '%{filtro}%' OR Convert([{coluna1}], 'System.String') LIKE '%{filtro}%'";
            dataGridView1.DataSource = dv;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = teste.InsertGeral(defineForms);
            label1.Text = "CONSULTA " + defineForms.ToUpper();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#edf1f3");
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeRows = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}