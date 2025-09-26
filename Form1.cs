namespace Zooka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {


                CadastroUsuario abrirfo1 = new CadastroUsuario();
                abrirfo1.MdiParent = this;
                abrirfo1.Show();
            }
            else
            {

                this.MdiChildren[0].Activate();
            }

        }
    }
}
