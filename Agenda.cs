using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SisVendas;

namespace Zooka
{
    public partial class Agenda : Form
    {
        private Conexao conexao = new Conexao();

        int mes = 0;
        int ano = 0;
        string hora = string.Empty;

        public static int static_mes = 0;
        public static int static_ano = 0;
        public static string static_hora = string.Empty;

        private int _idAgendamentoSelecionado = 0;


        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            mes = agora.Month;
            ano = agora.Year;
            hora = agora.ToString("HH:mm");

            displayDias();
        }

        public void displayDias()
        {
            hora = DateTime.Now.ToString("HH:mm");

            static_mes = mes;
            static_ano = ano;
            static_hora = hora;

            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lblMesAno.Text = nomeMes + " " + ano;

            DateTime inicioDoMes = new DateTime(ano, mes, 1);
            int dias = DateTime.DaysInMonth(ano, mes);
            int diaDaSemana = Convert.ToInt32(inicioDoMes.DayOfWeek.ToString("d")) + 1;

            lpDay.Controls.Clear();

            // Lógica para DIAS DO MÊS ANTERIOR
            int numTrailingDays = diaDaSemana - 1;

            if (numTrailingDays > 0)
            {
                DateTime prevMonth = inicioDoMes.AddMonths(-1);
                int diasPrevMonth = DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
                int startDay = diasPrevMonth - numTrailingDays + 1;

                for (int i = startDay; i <= diasPrevMonth; i++)
                {
                    ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                    lpDay.Controls.Add(controlAgendaBranco);
                    controlAgendaBranco.days(i);
                }
            }

            // DIAS DO MÊS ATUAL
            for (int i = 1; i <= dias; i++)
            {
                ControlAgendaDias controlAgendaDias = new ControlAgendaDias();
                lpDay.Controls.Add(controlAgendaDias);
                controlAgendaDias.days(i);

                controlAgendaDias.MouseDown += SeuControleDeAgendamentos_MouseDown;
            }

            // LÓGICA PARA DIAS DO PRÓXIMO MÊS
            int totalDaysDisplayed = numTrailingDays + dias;
            int remainingSlots = 42 - totalDaysDisplayed;

            if (remainingSlots > 0)
            {
                for (int i = 1; i <= remainingSlots; i++)
                {
                    ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                    lpDay.Controls.Add(controlAgendaBranco);
                    controlAgendaBranco.days(i);
                }
            }

            lpDay.Invalidate();
            lpDay.Update();
            this.Refresh();
        }

        // --- NAVEGAÇÃO E LÓGICA DE CLIQUE ---

        private void btnProximo_Click(object sender, EventArgs e)
        {
            mes++;
            if (mes > 12) { mes = 1; ano++; }
            displayDias();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            mes--;
            if (mes < 1) { mes = 12; ano--; }
            displayDias();
        }

        private void SeuControleDeAgendamentos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is ControlAgendaDias cardClicado)
                {
                    _idAgendamentoSelecionado = cardClicado.IdAgendamento;
                }

                bool temAgendamento = _idAgendamentoSelecionado > 0;

                tsmIncluir.Visible = true;
                tsmEditar.Visible = temAgendamento;
                tsmRemover.Visible = temAgendamento;

                tsmStatusConfirmado.Visible = temAgendamento;
                tsmStatusCancelado.Visible = temAgendamento;
                tsmStatusCompareceu.Visible = temAgendamento;
                tsmStatusRemarcado.Visible = temAgendamento;

                cmsAgendamento.Show(Cursor.Position);
            }
        }

        // --- MÉTODOS DE AÇÃO DO MENU ---

        private void tsmIncluir_Click(object sender, EventArgs e)
        {
            AgendamentoHorario frm = new AgendamentoHorario();
            frm.AgendamentoAlterado += displayDias;
            frm.ShowDialog();
            displayDias();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            // Apenas abre o formulário para edição. A atualização é feita após o fechamento.
            if (_idAgendamentoSelecionado > 0)
            {
                AgendamentoHorario frm = new AgendamentoHorario(_idAgendamentoSelecionado);
                frm.AgendamentoAlterado += displayDias;
                frm.ShowDialog();
                displayDias();
            }
        }

        private void tsmRemover_Click(object sender, EventArgs e)
        {
            // *** FIX DEFINITIVO: EXCLUSÃO DIRETA POR SQL ***
            if (_idAgendamentoSelecionado <= 0)
            {
                MessageBox.Show("Nenhum agendamento válido selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja EXCLUIR este agendamento? Esta ação é irreversível.",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No) return;

            // Execução do DELETE no banco de dados
            using (var conn = conexao.GetConnection())
            {
                string comando = "DELETE FROM agenda_vet WHERE id_agenda_vet = @idExclusao";

                try
                {
                    using (var cmd = new MySqlCommand(comando, conn))
                    {
                        cmd.Parameters.AddWithValue("@idExclusao", _idAgendamentoSelecionado);
                        conn.Open();
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Agendamento excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayDias(); // ATUALIZA A TELA INSTANTANEAMENTE
                        }
                        else
                        {
                            MessageBox.Show("Agendamento não encontrado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao excluir agendamento: {ex.Message}", "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- ATUALIZAÇÕES DE STATUS ---

        private void tsmStatusConfirmado_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoSelecionado > 0)
            {
                UpdateStatusAgendamento(_idAgendamentoSelecionado, "CONFIRMADO");
                displayDias();
            }
        }

        private void tsmStatusCancelado_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoSelecionado > 0)
            {
                UpdateStatusAgendamento(_idAgendamentoSelecionado, "CANCELADO"); // <<-- CORRIGIDO PARA CANCELADO
                displayDias();
            }
        }

        private void tsmStatusCompareceu_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoSelecionado > 0)
            {
                UpdateStatusAgendamento(_idAgendamentoSelecionado, "COMPARECEU");
                displayDias();
            }
        }

        private void tsmStatusRemarcado_Click(object sender, EventArgs e)
        {
            if (_idAgendamentoSelecionado > 0)
            {
                UpdateStatusAgendamento(_idAgendamentoSelecionado, "REMARCADO");
                displayDias();
            }
        }

        private void UpdateStatusAgendamento(int idAgendamento, string novoStatus)
        {
            string comando = "UPDATE agenda_vet SET status_agenda_vet = @status WHERE id_agenda_vet = @id";

            using (var conn = conexao.GetConnection())
            using (var cmd = new MySqlCommand(comando, conn))
            {
                cmd.Parameters.AddWithValue("@status", novoStatus);
                cmd.Parameters.AddWithValue("@id", idAgendamento);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar status: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lpDay_Paint(object sender, PaintEventArgs e) { }
    }
}