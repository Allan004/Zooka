using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooka
{
    public partial class Agenda : Form
    {
        int mes, ano;
        string hora;

        public static int static_mes, static_ano;
        public static string static_hora;


        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            displayDias();
        }

        public void displayDias()
        {
            DateTime agora = DateTime.Now;
            mes = agora.Month;
            ano = agora.Year;
            hora = agora.ToString("HH:mm");

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAno.Text = nomeMes + " " + ano;

            static_mes = mes;
            static_ano = ano;
            static_hora = hora;
            DateTime inicioDoMes = new DateTime(ano, mes, 1);

            int dias = DateTime.DaysInMonth(ano, mes);

            int diaDaSemana = Convert.ToInt32(inicioDoMes.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < diaDaSemana; i++)
            {
                ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                lpDay.Controls.Add(controlAgendaBranco);
            }

            for (int i = 1; i <= dias; i++)
            {
                ControlAgendaDias controlAgendaDias = new ControlAgendaDias();
                controlAgendaDias.days(i);
                lpDay.Controls.Add(controlAgendaDias);
            }

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

            lpDay.Controls.Clear();

            mes++;
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAno.Text = nomeMes + " " + ano;

            static_mes = mes;
            static_ano = ano;
            static_hora = hora;

            DateTime agora = DateTime.Now;

            DateTime inicioDoMes = new DateTime(ano, mes, 1);

            int dias = DateTime.DaysInMonth(ano, mes);

            int diaDaSemana = Convert.ToInt32(inicioDoMes.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < diaDaSemana; i++)
            {
                ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                lpDay.Controls.Add(controlAgendaBranco);
            }

            for (int i = 1; i <= dias; i++)
            {
                ControlAgendaDias controlAgendaDias = new ControlAgendaDias();
                controlAgendaDias.days(i);
                lpDay.Controls.Add(controlAgendaDias);
            }

        }


        private void btnAnterior_Click(object sender, EventArgs e)
        {
            lpDay.Controls.Clear();

            mes--;
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAno.Text = nomeMes + " " + ano;

            static_mes = mes;
            static_ano = ano;
            static_hora = hora;

            DateTime agora = DateTime.Now;

            DateTime inicioDoMes = new DateTime(ano, mes, 1);

            int dias = DateTime.DaysInMonth(ano, mes);

            int diaDaSemana = Convert.ToInt32(inicioDoMes.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < diaDaSemana; i++)
            {
                ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                lpDay.Controls.Add(controlAgendaBranco);
            }

            for (int i = 1; i <= dias; i++)
            {
                ControlAgendaDias controlAgendaDias = new ControlAgendaDias();
                controlAgendaDias.days(i);
                lpDay.Controls.Add(controlAgendaDias);
            }
        }

        private void lpDay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
