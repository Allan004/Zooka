using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Zooka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EstilizarFundoMDI();

        }

        private void EstilizarFundoMDI()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient client)
                {
                    client.BackColor = Color.LightBlue; 
                    // ou qualquer outra cor
                    // Para usar uma imagem:
                    // client.BackgroundImage = Image.FromFile("caminho_para_imagem.jpg");
                    // client.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }
        public void fechamenu(bool fecharm)
        {
            if (fecharm == true)
            {
                button2.Visible = true;
                button3.Visible = true;
                btnEstoque.Visible = true;
                BtnOrdemdecompra.Visible = true;
                btnFornecedor.Visible = true;
                button7.Visible = true;
            }
            if (fecharm == false)
            {
                button2.Visible = false;
                button3.Visible = false;
                btnEstoque.Visible = false;
                BtnOrdemdecompra.Visible = false;
                btnFornecedor.Visible = false;
                button7.Visible = false;

            }

        }

        int cont = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                fechamenu(true);
                cont = 1;
            }
            else
            {
                fechamenu(false);
                cont = 0;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnSku.Visible = true;
        }
        public void somelimpa(bool verifica)
        {
            if (verifica == true)
            {
                btnCliente.Visible = true;
                btnPet.Visible = true;
                btnProfissional.Visible = true;
                btnUsuario.Visible = true;

            }
            if (verifica == false)
            {
                btnCliente.Visible = false;
                btnPet.Visible = false;
                btnProfissional.Visible = false;
                btnUsuario.Visible = false;

            }

        }
        int cont2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont2 == 0)
            {
                somelimpa(true);
                cont2 = 1;
            }
            else
            {
                somelimpa(false);
                cont2 = 0;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            Cadastro_Pet pet = new Cadastro_Pet();
            pet.TopLevel = false;
            pet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pet.StartPosition = FormStartPosition.Manual;
            pet.Location = new Point(0, 0);
            pet.MdiParent = this;
            pet.Show();
            somelimpa(false);
            fechamenu(false);
            cont = 0;
            cont2 = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastroFornecedor abrirFornecedor = new CadastroFornecedor();
            abrirFornecedor.Show();
        }



        private void btnCliente_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroCliente abrirform = new CadastroCliente();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            somelimpa(false);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void btnProfissional_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroProfissional abrirform = new CadastroProfissional();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            somelimpa(false);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroUsuario abrirform = new CadastroUsuario();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            somelimpa(false);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void btnSku_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroSKU abrirform = new CadastroSKU();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            btnSku.Visible = false;
            fechamenu(false);
            cont = 0;
            cont2 = 0;

        }

        private void BtnOrdemdecompra_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            ordem_de_compra abrirform = new ordem_de_compra();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
