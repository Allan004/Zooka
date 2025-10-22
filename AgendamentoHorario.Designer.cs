namespace Zooka
{
    partial class AgendamentoHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendamentoHorario));
            txtDia = new TextBox();
            lblData = new Label();
            btnSalvar = new Button();
            txtHora = new TextBox();
            lblHorario = new Label();
            lblAgendaCliente = new Label();
            lblPet = new Label();
            txtProfissional = new TextBox();
            txtServico = new TextBox();
            lblProfissional = new Label();
            lblServico = new Label();
            btnExcluir = new Button();
            cmbPet = new ComboBox();
            txtAgendaCliente = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(41, 128);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(121, 23);
            txtDia.TabIndex = 0;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblData.ForeColor = Color.FromArgb(215, 122, 40);
            lblData.Location = new Point(41, 102);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 23);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvar.FlatAppearance.BorderColor = Color.Red;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Transparent;
            btnSalvar.Location = new Point(140, 450);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(362, 128);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(125, 23);
            txtHora.TabIndex = 3;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblHorario.ForeColor = Color.FromArgb(215, 122, 40);
            lblHorario.Location = new Point(362, 102);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(66, 23);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário";
            // 
            // lblAgendaCliente
            // 
            lblAgendaCliente.AutoSize = true;
            lblAgendaCliente.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblAgendaCliente.ForeColor = Color.FromArgb(215, 122, 40);
            lblAgendaCliente.Location = new Point(273, 185);
            lblAgendaCliente.Name = "lblAgendaCliente";
            lblAgendaCliente.Size = new Size(62, 23);
            lblAgendaCliente.TabIndex = 1;
            lblAgendaCliente.Text = "Cliente";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblPet.ForeColor = Color.FromArgb(215, 122, 40);
            lblPet.Location = new Point(41, 256);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(34, 23);
            lblPet.TabIndex = 1;
            lblPet.Text = "Pet";
            // 
            // txtProfissional
            // 
            txtProfissional.Location = new Point(41, 360);
            txtProfissional.Name = "txtProfissional";
            txtProfissional.Size = new Size(209, 23);
            txtProfissional.TabIndex = 0;
            // 
            // txtServico
            // 
            txtServico.Location = new Point(273, 360);
            txtServico.Name = "txtServico";
            txtServico.Size = new Size(214, 23);
            txtServico.TabIndex = 0;
            // 
            // lblProfissional
            // 
            lblProfissional.AutoSize = true;
            lblProfissional.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblProfissional.ForeColor = Color.FromArgb(215, 122, 40);
            lblProfissional.Location = new Point(41, 334);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(100, 23);
            lblProfissional.TabIndex = 1;
            lblProfissional.Text = "Profissional";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblServico.ForeColor = Color.FromArgb(215, 122, 40);
            lblServico.Location = new Point(273, 334);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(67, 23);
            lblServico.TabIndex = 1;
            lblServico.Text = "Serviço";
            // 
            // btnExcluir
            // 
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluir.FlatAppearance.BorderColor = Color.FromArgb(169, 213, 186);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Snow;
            btnExcluir.Location = new Point(273, 450);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // cmbPet
            // 
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(41, 284);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(121, 23);
            cmbPet.TabIndex = 6;
            // 
            // txtAgendaCliente
            // 
            txtAgendaCliente.Location = new Point(273, 211);
            txtAgendaCliente.Name = "txtAgendaCliente";
            txtAgendaCliente.Size = new Size(214, 23);
            txtAgendaCliente.TabIndex = 0;
            txtAgendaCliente.TextChanged += txtAgendaCliente_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(41, 211);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(209, 23);
            txtCpf.TabIndex = 0;
            txtCpf.TextChanged += txtAgendaCliente_TextChanged;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCpf.ForeColor = Color.FromArgb(215, 122, 40);
            lblCpf.Location = new Point(41, 185);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(41, 23);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20F);
            label1.ForeColor = Color.FromArgb(215, 122, 40);
            label1.Location = new Point(186, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 1;
            label1.Text = "Agendamento";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // AgendamentoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(531, 523);
            Controls.Add(pictureBox1);
            Controls.Add(cmbPet);
            Controls.Add(btnExcluir);
            Controls.Add(txtHora);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(lblHorario);
            Controls.Add(lblPet);
            Controls.Add(lblServico);
            Controls.Add(lblCpf);
            Controls.Add(lblAgendaCliente);
            Controls.Add(lblProfissional);
            Controls.Add(lblData);
            Controls.Add(txtServico);
            Controls.Add(txtProfissional);
            Controls.Add(txtCpf);
            Controls.Add(txtAgendaCliente);
            Controls.Add(txtDia);
            Name = "AgendamentoHorario";
            Text = "AgendamentoHorario";
            Load += AgendamentoHorario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private Label lblData;
        private Button btnSalvar;
        private TextBox txtHora;
        private Label lblHorario;
        private Label lblAgendaCliente;
        private Label lblPet;
        private TextBox txtProfissional;
        private TextBox txtServico;
        private Label lblProfissional;
        private Label lblServico;
        private Button btnExcluir;
        private ComboBox cmbPet;
        private TextBox txtAgendaCliente;
        private TextBox txtCpf;
        private Label lblCpf;
        private Label label1;
        private PictureBox pictureBox1;
    }
}