using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zooka
{

    // Representa um slot de dia "vazio" (inativo) em um calendário/agenda.

    public partial class ControlAgendaBranco : UserControl
    {
        public ControlAgendaBranco()
        {
            InitializeComponent();
        }

        // Define e exibe o número do dia, aplicando um estilo visual que indica inatividade.
        public void days(int numDia)
        {
            // O controle deve exibir o número do dia, mas com cor/fundo que sinalizam que não é do mês atual.
            if (lblControleAgendaBrancoDia != null)
            {
                lblControleAgendaBrancoDia.Text = numDia.ToString();
                // Estilo para indicar dia inativo.
                lblControleAgendaBrancoDia.ForeColor = Color.DarkGray;
                this.BackColor = Color.FromArgb(240, 240, 240); // Fundo mais claro/cinza.

                // Garante a correta renderização do Label sobre o fundo do UserControl.
                lblControleAgendaBrancoDia.Visible = true;
                lblControleAgendaBrancoDia.BringToFront();

                // Força o redesenho imediato, comum em controles de calendários complexos.
                this.Invalidate();
                this.Update();
            }
        }
    }
}