using MySql.Data.MySqlClient;
using SisVendas;
using System.Data;

namespace Zooka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TESTE();
        }

        private void cadastroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {


                CadastroUsuario abrirusuario = new CadastroUsuario();
                abrirusuario.MdiParent = this;
                abrirusuario.Show();
            }
            else
            {

                this.MdiChildren[0].Activate();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public DataTable TESTE()

        {

            string sql = "SELECT * FROM gridprod";

            Conexao conexao = new Conexao();

            using (var conn = conexao.GetConnection())

            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))

                {

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt;

                }

            }



        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeSKUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {


                CadastroSKU abrirsku = new CadastroSKU();
                abrirsku.MdiParent = this;
                abrirsku.Show();
            }
            else
            {

                this.MdiChildren[0].Activate();
            }
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length ==0)
            {


                CadastroCliente abrirform = new CadastroCliente();
                abrirform.MdiParent = this;
                abrirform.Show();
            }
            else
            {

                this.MdiChildren[0].Activate();
            }

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }
    }
}
