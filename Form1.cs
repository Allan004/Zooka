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



            CadastroUsuario abrirusuario = new CadastroUsuario();
            abrirusuario.MdiParent = this;
            abrirusuario.Show();


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


            CadastroSKU abrirsku = new CadastroSKU();
            abrirsku.MdiParent = this;
            abrirsku.Show();


        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {



            CadastroCliente abrirform = new CadastroCliente();
            abrirform.MdiParent = this;
            abrirform.Show();



        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void cadastroPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Pet pet = new Cadastro_Pet();
            pet.MdiParent = this;
            pet.Show();

        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProfissional prof = new CadastroProfissional();
            prof.MdiParent = this;
            prof.Show();
        }

        private void cADASTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsuario prof = new LoginUsuario();
            prof.MdiParent = this;
            prof.Show();
        }
        
        
        
    }
}
