using MySql.Data.MySqlClient;
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
    public partial class ordem_de_compra : Form
    {
        public ordem_de_compra()
        {
            InitializeComponent();
        }

        private void ordem_de_compra_Load(object sender, EventArgs e)
        {
            // Deixar a TextBox "desabilitada" visualmente, mas mantendo o fundo branco
            txtNumeroOC.ReadOnly = true;          // Impede digitação
            txtNumeroOC.BackColor = Color.White;  // Mantém o fundo branco
            txtNumeroOC.ForeColor = Color.Gray;   // Texto cinza

            string connStr = "server=10.37.44.26;user id=root;password=root;database=Zooka";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MAX(id_oc) FROM ordem_de_compra";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int proximoID = (result == null || result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                    txtNumeroOC.Text = proximoID.ToString();

                    // Bloqueia edição e foco, mas mantém aparência normal
                    txtNumeroOC.TabStop = false;
                }
            }
        }
    }
}