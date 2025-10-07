namespace Zooka
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            lpDay = new FlowLayoutPanel();
            lblDomingo = new Label();
            lblSegunda = new Label();
            btnProximo = new Button();
            btnAnterior = new Button();
            lblMesAno = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmsAgendamento = new ContextMenuStrip(components);
            tsmIncluir = new ToolStripMenuItem();
            tsmEditar = new ToolStripMenuItem();
            tsmRemover = new ToolStripMenuItem();
            tsmStatus = new ToolStripMenuItem();
            tsmStatusConfirmado = new ToolStripMenuItem();
            tsmStatusCancelado = new ToolStripMenuItem();
            tsmStatusCompareceu = new ToolStripMenuItem();
            cmsAgendamento.SuspendLayout();
            SuspendLayout();
            // 
            // lpDay
            // 
            lpDay.Location = new Point(12, 118);
            lpDay.Name = "lpDay";
            lpDay.Size = new Size(1828, 931);
            lpDay.TabIndex = 0;
            // 
            // lblDomingo
            // 
            lblDomingo.BackColor = SystemColors.ActiveCaption;
            lblDomingo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomingo.Location = new Point(15, 91);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(238, 25);
            lblDomingo.TabIndex = 1;
            lblDomingo.Text = "DOM";
            lblDomingo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSegunda
            // 
            lblSegunda.BackColor = SystemColors.ActiveCaption;
            lblSegunda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSegunda.Location = new Point(259, 90);
            lblSegunda.Name = "lblSegunda";
            lblSegunda.Size = new Size(238, 25);
            lblSegunda.TabIndex = 1;
            lblSegunda.Text = "SEG";
            lblSegunda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.Transparent;
            btnProximo.BackgroundImage = (Image)resources.GetObject("btnProximo.BackgroundImage");
            btnProximo.BackgroundImageLayout = ImageLayout.Zoom;
            btnProximo.FlatAppearance.BorderSize = 0;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Location = new Point(299, 20);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(64, 42);
            btnProximo.TabIndex = 3;
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.BackgroundImage = (Image)resources.GetObject("btnAnterior.BackgroundImage");
            btnAnterior.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(229, 20);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(64, 42);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblMesAno
            // 
            lblMesAno.AutoSize = true;
            lblMesAno.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesAno.Location = new Point(15, 9);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(200, 50);
            lblMesAno.TabIndex = 1;
            lblMesAno.Text = "Mês / Ano";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(503, 90);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 1;
            label1.Text = "TER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(747, 90);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 1;
            label2.Text = "QUA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(991, 90);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 1;
            label3.Text = "QUI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(1235, 90);
            label4.Name = "label4";
            label4.Size = new Size(238, 25);
            label4.TabIndex = 1;
            label4.Text = "SEX";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(1479, 90);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 1;
            label5.Text = "SAB";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmsAgendamento
            // 
            cmsAgendamento.Items.AddRange(new ToolStripItem[] { tsmIncluir, tsmEditar, tsmRemover, tsmStatus });
            cmsAgendamento.Name = "cmsAgendamento";
            cmsAgendamento.Size = new Size(122, 92);
            // 
            // tsmIncluir
            // 
            tsmIncluir.Name = "tsmIncluir";
            tsmIncluir.Size = new Size(180, 22);
            tsmIncluir.Text = "Incluir ";
            // 
            // tsmEditar
            // 
            tsmEditar.Name = "tsmEditar";
            tsmEditar.Size = new Size(180, 22);
            tsmEditar.Text = "Editar";
            // 
            // tsmRemover
            // 
            tsmRemover.Name = "tsmRemover";
            tsmRemover.Size = new Size(180, 22);
            tsmRemover.Text = "Remover";
            // 
            // tsmStatus
            // 
            tsmStatus.DropDownItems.AddRange(new ToolStripItem[] { tsmStatusConfirmado, tsmStatusCancelado, tsmStatusCompareceu });
            tsmStatus.Name = "tsmStatus";
            tsmStatus.Size = new Size(180, 22);
            tsmStatus.Text = "Status";
            // 
            // tsmStatusConfirmado
            // 
            tsmStatusConfirmado.Name = "tsmStatusConfirmado";
            tsmStatusConfirmado.Size = new Size(180, 22);
            tsmStatusConfirmado.Text = "CONFIRMADO";
            // 
            // tsmStatusCancelado
            // 
            tsmStatusCancelado.Name = "tsmStatusCancelado";
            tsmStatusCancelado.Size = new Size(180, 22);
            tsmStatusCancelado.Text = "COMPARECEU";
            // 
            // tsmStatusCompareceu
            // 
            tsmStatusCompareceu.Name = "tsmStatusCompareceu";
            tsmStatusCompareceu.Size = new Size(180, 22);
            tsmStatusCompareceu.Text = "CANCELADO";
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 1061);
            Controls.Add(btnAnterior);
            Controls.Add(btnProximo);
            Controls.Add(lblMesAno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSegunda);
            Controls.Add(lblDomingo);
            Controls.Add(lpDay);
            Name = "Agenda";
            Text = "Agenda";
            Load += Agenda_Load;
            cmsAgendamento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel lpDay;
        private Label lblDomingo;
        private Label lblSegunda;
        private Button btnProximo;
        private Button btnAnterior;
        private Label lblMesAno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip cmsAgendamento;
        private ToolStripMenuItem tsmIncluir;
        private ToolStripMenuItem tsmEditar;
        private ToolStripMenuItem tsmRemover;
        private ToolStripMenuItem tsmStatus;
        private ToolStripMenuItem tsmStatusConfirmado;
        private ToolStripMenuItem tsmStatusCancelado;
        private ToolStripMenuItem tsmStatusCompareceu;
    }
}