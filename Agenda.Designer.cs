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
            tsmStatusRemarcado = new ToolStripMenuItem();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cmsAgendamento.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lpDay
            // 
            lpDay.BackColor = Color.FromArgb(34, 61, 79);
            lpDay.Location = new Point(1, 118);
            lpDay.Name = "lpDay";
            lpDay.Size = new Size(1735, 949);
            lpDay.TabIndex = 0;
            // 
            // lblDomingo
            // 
            lblDomingo.BackColor = Color.FromArgb(215, 122, 40);
            lblDomingo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomingo.ForeColor = Color.White;
            lblDomingo.Location = new Point(4, 91);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(238, 25);
            lblDomingo.TabIndex = 1;
            lblDomingo.Text = "DOM";
            lblDomingo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSegunda
            // 
            lblSegunda.BackColor = Color.FromArgb(215, 122, 40);
            lblSegunda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSegunda.ForeColor = Color.White;
            lblSegunda.Location = new Point(251, 91);
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
            btnProximo.Location = new Point(1240, 25);
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
            btnAnterior.Location = new Point(1146, 25);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(78, 42);
            btnAnterior.TabIndex = 3;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblMesAno
            // 
            lblMesAno.AutoSize = true;
            lblMesAno.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesAno.ForeColor = Color.White;
            lblMesAno.Location = new Point(1397, 17);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(200, 50);
            lblMesAno.TabIndex = 1;
            lblMesAno.Text = "Mês / Ano";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(215, 122, 40);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(496, 91);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 1;
            label1.Text = "TER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(215, 122, 40);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(739, 91);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 1;
            label2.Text = "QUA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(215, 122, 40);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(984, 91);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 1;
            label3.Text = "QUI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(215, 122, 40);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1227, 91);
            label4.Name = "label4";
            label4.Size = new Size(238, 25);
            label4.TabIndex = 1;
            label4.Text = "SEX";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(215, 122, 40);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1470, 91);
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
            tsmIncluir.Size = new Size(121, 22);
            tsmIncluir.Text = "Incluir ";
            tsmIncluir.Click += tsmIncluir_Click;
            // 
            // tsmEditar
            // 
            tsmEditar.Name = "tsmEditar";
            tsmEditar.Size = new Size(121, 22);
            tsmEditar.Text = "Editar";
            tsmEditar.Click += tsmEditar_Click;
            // 
            // tsmRemover
            // 
            tsmRemover.Name = "tsmRemover";
            tsmRemover.Size = new Size(121, 22);
            tsmRemover.Text = "Remover";
            tsmRemover.Click += tsmRemover_Click;
            // 
            // tsmStatus
            // 
            tsmStatus.DropDownItems.AddRange(new ToolStripItem[] { tsmStatusConfirmado, tsmStatusCancelado, tsmStatusCompareceu, tsmStatusRemarcado });
            tsmStatus.Name = "tsmStatus";
            tsmStatus.Size = new Size(121, 22);
            tsmStatus.Text = "Status";
            // 
            // tsmStatusConfirmado
            // 
            tsmStatusConfirmado.Name = "tsmStatusConfirmado";
            tsmStatusConfirmado.Size = new Size(152, 22);
            tsmStatusConfirmado.Text = "CONFIRMADO";
            tsmStatusConfirmado.Click += tsmStatusConfirmado_Click;
            // 
            // tsmStatusCancelado
            // 
            tsmStatusCancelado.Name = "tsmStatusCancelado";
            tsmStatusCancelado.Size = new Size(152, 22);
            tsmStatusCancelado.Text = "COMPARECEU";
            tsmStatusCancelado.Click += tsmStatusCompareceu_Click;
            // 
            // tsmStatusCompareceu
            // 
            tsmStatusCompareceu.Name = "tsmStatusCompareceu";
            tsmStatusCompareceu.Size = new Size(152, 22);
            tsmStatusCompareceu.Text = "CANCELADO";
            tsmStatusCompareceu.Click += tsmStatusCancelado_Click;
            // 
            // tsmStatusRemarcado
            // 
            tsmStatusRemarcado.Name = "tsmStatusRemarcado";
            tsmStatusRemarcado.Size = new Size(152, 22);
            tsmStatusRemarcado.Text = "REMARCADO";
            tsmStatusRemarcado.Click += tsmStatusRemarcado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAnterior);
            panel1.Controls.Add(lblMesAno);
            panel1.Controls.Add(btnProximo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1857, 87);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 20F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(673, 31);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 5;
            label6.Text = "Agenda";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(788, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1726, 1061);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private ToolStripMenuItem tsmStatusRemarcado;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}