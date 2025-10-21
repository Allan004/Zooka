using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zooka
{
    // A classe principal que representa o calendário/agenda na interface.
    public partial class Agenda : Form
    {
        // Instância da classe de conexão, usada para todas as operações de banco de dados.
        private Conexao conexao = new Conexao();

        // Variáveis de controle para o mês e ano atualmente exibidos no calendário.
        int mes = 0;
        int ano = 0;
        string hora = string.Empty;


        public static int static_mes = 0;
        public static int static_ano = 0;
        public static string static_hora = string.Empty;

        // Armazena o ID do agendamento que foi clicado
        private int _idAgendamentoSelecionado = 0;

        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            // Inicializa o calendário com o mês e ano atuais.
            mes = agora.Month;
            ano = agora.Year;
            hora = agora.ToString("HH:mm");

            displayDias();
        }


        // Gera e exibe o calendário (dias) na interface para o mês e ano atuais.

        public void displayDias()
        {
            // Atualiza o horário atual (mantendo as variáveis estáticas atualizadas para os controles)
            hora = DateTime.Now.ToString("HH:mm");
            static_mes = mes;
            static_ano = ano;
            static_hora = hora;

            // Define o rótulo da interface (ex: OUTUBRO 2025).
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToUpper();
            lblMesAno.Text = nomeMes + " " + ano;

            // Calcula o primeiro dia da semana do mês atual.
            DateTime inicioDoMes = new DateTime(ano, mes, 1);
            int dias = DateTime.DaysInMonth(ano, mes);
            // DayOfWeek retorna 0 para Domingo. Convertemos para ter 1=Domingo, 2=Segunda, etc.
            int diaDaSemana = Convert.ToInt32(inicioDoMes.DayOfWeek.ToString("d")) + 1;

            // Limpa todos os controles de dias anteriores para redesenhar o calendário.
            lpDay.Controls.Clear();

            //  Lógica para DIAS DO MÊS ANTERIOR  
            // Calcula quantos dias do mês anterior devem ser mostrados no início da grade.
            int numTrailingDays = diaDaSemana - 1;

            if (numTrailingDays > 0)
            {
                DateTime prevMonth = inicioDoMes.AddMonths(-1);
                int diasPrevMonth = DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
                int startDay = diasPrevMonth - numTrailingDays + 1;

                for (int i = startDay; i <= diasPrevMonth; i++)
                {
                    // Usa um controle "vazio" para preencher os dias que caem no mês anterior.
                    ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                    lpDay.Controls.Add(controlAgendaBranco);
                    controlAgendaBranco.days(i);
                }
            }

            // DIAS DO MÊS ATUAL 
            for (int i = 1; i <= dias; i++)
            {
                // Cria e adiciona o controle de dia (com a lógica de agendamento).
                ControlAgendaDias controlAgendaDias = new ControlAgendaDias();
                lpDay.Controls.Add(controlAgendaDias);
                controlAgendaDias.days(i);

                // Adiciona o evento de clique do mouse (necessário para o menu de contexto)
                controlAgendaDias.MouseDown += SeuControleDeAgendamentos_MouseDown;
            }

            // LÓGICA PARA DIAS DO PRÓXIMO MÊS 
            // A grade tem 42 slots (6 linhas x 7 colunas).
            int totalDaysDisplayed = numTrailingDays + dias;
            int remainingSlots = 42 - totalDaysDisplayed;

            if (remainingSlots > 0)
            {
                for (int i = 1; i <= remainingSlots; i++)
                {
                    // Usa um controle "vazio" para preencher os dias que caem no próximo mês.
                    ControlAgendaBranco controlAgendaBranco = new ControlAgendaBranco();
                    lpDay.Controls.Add(controlAgendaBranco);
                    controlAgendaBranco.days(i);
                }
            }

            // Força a atualização visual do painel.
            lpDay.Invalidate();
            lpDay.Update();
            this.Refresh();
        }

        //  NAVEGAÇÃO E LÓGICA DE CLIQUE

        private void btnProximo_Click(object sender, EventArgs e)
        {
            // Avança para o próximo mês, ajustando o ano se necessário.
            mes++;
            if (mes > 12) { mes = 1; ano++; }
            displayDias();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Volta para o mês anterior, ajustando o ano se necessário.
            mes--;
            if (mes < 1) { mes = 12; ano--; }
            displayDias();
        }


        // Handler para o clique do mouse em um dia do calendário.
        // Exibe o menu de contexto (botão direito).

        private void SeuControleDeAgendamentos_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica se foi um clique com o botão direito.
            if (e.Button == MouseButtons.Right)
            {
                if (sender is ControlAgendaDias cardClicado)
                {
                    // Tenta obter o ID do agendamento vinculado ao controle de dia.
                    _idAgendamentoSelecionado = cardClicado.IdAgendamento;
                }

                // Determina a visibilidade das opções do menu (Editar/Remover/Status).
                bool temAgendamento = _idAgendamentoSelecionado > 0;

                // Opções CRUD (Incluir sempre visível, Edição/Remoção dependem da seleção).
                tsmIncluir.Visible = true;
                tsmEditar.Visible = temAgendamento;
                tsmRemover.Visible = temAgendamento;

                // Opções de Status só são visíveis se um agendamento válido foi selecionado.
                tsmStatusConfirmado.Visible = temAgendamento;
                tsmStatusCancelado.Visible = temAgendamento;
                tsmStatusCompareceu.Visible = temAgendamento;
                tsmStatusRemarcado.Visible = temAgendamento;

                // Exibe o menu de contexto na posição do cursor.
                cmsAgendamento.Show(Cursor.Position);
            }
        }

        //  MÉTODOS DE AÇÃO DO MENU 

        private void tsmIncluir_Click(object sender, EventArgs e)
        {
            // Abre o formulário de horários para inclusão de um novo agendamento.
            AgendamentoHorario frm = new AgendamentoHorario();
            // Assina um delegate para que a tela atualize (displayDias) ao fechar o formulário.
            frm.AgendamentoAlterado += displayDias;
            frm.ShowDialog();
            // Chama displayDias novamente caso o delegate não tenha sido disparado por algum motivo.
            displayDias();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de horários em modo de edição, passando o ID selecionado.
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
            // Validação de segurança: verifica se há um ID válido para exclusão.
            if (_idAgendamentoSelecionado <= 0)
            {
                MessageBox.Show("Nenhum agendamento válido selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pede confirmação antes de executar a exclusão (ação irreversível).
            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza que deseja EXCLUIR este agendamento? Esta ação é irreversível.",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.No) return;

            // Execução do DELETE no banco de dados. 
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
                            displayDias(); // ATUALIZA A TELA para remover o item excluído.
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

        //  ATUALIZAÇÕES DE STATUS 
        // Todos os métodos de status chamam o método centralizado UpdateStatusAgendamento.

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
                UpdateStatusAgendamento(_idAgendamentoSelecionado, "CANCELADO");
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


        // Método centralizado para executar a query de UPDATE de status.

        // <param name="idAgendamento">O ID único do agendamento a ser atualizado.</param>
        // <param name="novoStatus">O valor do novo status a ser gravado no banco.</param>
        private void UpdateStatusAgendamento(int idAgendamento, string novoStatus)
        {
            // Query segura com parâmetros para evitar SQL Injection.
            string comando = "UPDATE agenda_vet SET status_agenda_vet = @status WHERE id_agenda_vet = @id";

            // Blocos 'using' aninhados garantem que a conexão e o comando sejam descartados.
            using (var conn = conexao.GetConnection())
            using (var cmd = new MySqlCommand(comando, conn))
            {
                cmd.Parameters.AddWithValue("@status", novoStatus);
                cmd.Parameters.AddWithValue("@id", idAgendamento);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // Não é necessário MessageBox de sucesso aqui, pois a tela é atualizada.
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar status: " + ex.Message, "Erro de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}