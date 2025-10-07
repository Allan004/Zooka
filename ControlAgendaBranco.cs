using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zooka
{
    public partial class ControlAgendaBranco : UserControl
    {
        public ControlAgendaBranco()
        {
            InitializeComponent();
        }

        // Método que exibe o número do dia com estilo
        public void days(int numDia)
        {
            // FIX: Adiciona comandos de visibilidade e ordem de desenho
            if (lblControleAgendaBrancoDia != null)
            {
                lblControleAgendaBrancoDia.Text = numDia.ToString();
                lblControleAgendaBrancoDia.ForeColor = Color.DarkGray;
                this.BackColor = Color.FromArgb(240, 240, 240);

                // CRÍTICO: Garante que o Label esteja visível e acima de qualquer fundo
                lblControleAgendaBrancoDia.Visible = true;
                lblControleAgendaBrancoDia.BringToFront();

                // Força o redesenho agressivo (para garantir que o texto apareça)
                this.Invalidate();
                this.Update();
            }
        }

        private void ControlAgendaBranco_Load(object sender, EventArgs e)
        {
            // Deixado vazio
        }

        private void lblControleAgendaBrancoDia_Click(object sender, EventArgs e)
        {
            // Evento de clique
        }
    }
}