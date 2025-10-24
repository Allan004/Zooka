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
                    client.BackColor = ColorTranslator.FromHtml("#edf1f3");

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
                btnConsulta.Visible = true;
            }
            if (fecharm == false)
            {
                button2.Visible = false;
                button3.Visible = false;
                btnEstoque.Visible = false;
                BtnOrdemdecompra.Visible = false;
                btnFornecedor.Visible = false;
                btnConsulta.Visible = false;

            }

        }

        int cont = 0;
        int cont3 = 0;
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
                somelimpa(false, 1);
                cont2 = 0;
                somelimpa(false, 2);


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if (btnCadastroServico.Visible == false)
            {
                btnCadastroServico.Visible = true;
            }
            else
            {
                btnCadastroServico.Visible = false;
            }
        }
        public void somelimpa(bool verificaSubmenu, int controleSubmenu)
        {
            if (controleSubmenu == 1)
            {
                if (verificaSubmenu == true)
                {
                    btnCliente.Visible = true;
                    btnPet.Visible = true;
                    btnProfissional.Visible = true;
                    btnUsuario.Visible = true;
                    btnSku.Visible = true;
                    btnCadastroServico.Visible = true;
                    btnCadastroFornecedor.Visible = true;

                }
                if (verificaSubmenu == false)
                {
                    btnCliente.Visible = false;
                    btnPet.Visible = false;
                    btnProfissional.Visible = false;
                    btnUsuario.Visible = false;
                    btnSku.Visible = false;
                    btnCadastroServico.Visible = false;
                    btnCadastroFornecedor.Visible = false;
                }
            }
            if (controleSubmenu == 2)
            {
                if (verificaSubmenu == true)
                {
                    btnConsultaCliente.Visible = true;
                    btnConsultaPet.Visible = true;
                    btnConsultaProfissional.Visible = true;
                    btnConsultaUsuario.Visible = true;
                    btnConsultaSku.Visible = true;
                    btnConsultaServico.Visible = true;
                    btnConsultaFornecedor.Visible = true;
                }

                if (verificaSubmenu == false)
                {
                    btnConsultaCliente.Visible = false;
                    btnConsultaPet.Visible = false;
                    btnConsultaProfissional.Visible = false;
                    btnConsultaUsuario.Visible = false;
                    btnConsultaSku.Visible = false;
                    btnConsultaServico.Visible = false;
                    btnConsultaFornecedor.Visible = false;

                }


            }

        }
        int cont2 = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cont2 == 0)
            {
                somelimpa(true, 1);
                cont2 = 1;
            }
            else
            {
                somelimpa(false, 1);
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
            somelimpa(false, 1);
            somelimpa(false, 2);
            fechamenu(false);
            cont = 0;
            cont2 = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroFornecedor abrirFornecedor = new CadastroFornecedor();
            abrirFornecedor.TopLevel = false;
            abrirFornecedor.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirFornecedor.StartPosition = FormStartPosition.Manual;
            abrirFornecedor.Location = new Point(0, 0);
            abrirFornecedor.Show();
            somelimpa(false, 1);
            somelimpa(false, 2);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
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
            somelimpa(false, 1);
            somelimpa(false, 2);
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
            somelimpa(false, 1);
            somelimpa(false, 2);
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
            somelimpa(false, 1);
            somelimpa(false, 2);
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
            somelimpa(false, 1);
            somelimpa(false, 2);
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
            somelimpa(false, 1);
            somelimpa(false, 2);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void btnCadastroServico_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroServico abrirform = new CadastroServico();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            somelimpa(false, 1);
            somelimpa(false, 2);
            fechamenu(false);
            cont = 0;
            cont2 = 0;
        }

        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            CadastroFornecedor abrirform = new CadastroFornecedor();
            abrirform.TopLevel = false;
            abrirform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            abrirform.StartPosition = FormStartPosition.Manual;
            abrirform.Location = new Point(0, 0);
            abrirform.MdiParent = this;
            abrirform.Show();
            somelimpa(false, 1);
            somelimpa(false, 2);
            fechamenu(false);
            
            cont = 0;
            cont2 = 0;
        }

        
        private void btnConsulta_Click(object sender, EventArgs e)
        {
          if (cont3 == 0)
            {
                somelimpa(true, 2);
                cont3 = 1;
            }
            else
            {
                somelimpa(false, 2);
                cont3 = 0;
            }
        }
    }
}
