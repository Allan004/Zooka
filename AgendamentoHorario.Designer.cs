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
            pictureBox2 = new PictureBox();
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
            txtAgendaCliente = new TextBox();
            lblCpf = new Label();
            label1 = new Label();
            txtCpf = new MaskedTextBox();
            txtObservacao = new RichTextBox();
            lblObservacao = new Label();
            lblEspecie = new Label();
            lblRaca = new Label();
            txtEspecie = new TextBox();
            txtRaca = new TextBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            cmbPet = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(216, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txtDia
            // 
            txtDia.BackColor = Color.AliceBlue;
            txtDia.Font = new Font("Arial", 12F);
            txtDia.Location = new Point(34, 186);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(121, 26);
            txtDia.TabIndex = 0;
            txtDia.TextAlign = HorizontalAlignment.Center;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Gadugi", 12F);
            lblData.ForeColor = Color.FromArgb(34, 61, 79);
            lblData.Location = new Point(31, 164);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 19);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvar.FlatAppearance.BorderColor = Color.Red;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.Transparent;
            btnSalvar.Location = new Point(398, 683);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtHora
            // 
            txtHora.BackColor = Color.AliceBlue;
            txtHora.Font = new Font("Arial", 12F);
            txtHora.Location = new Point(383, 186);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(125, 26);
            txtHora.TabIndex = 3;
            txtHora.TextAlign = HorizontalAlignment.Center;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Gadugi", 12F);
            lblHorario.ForeColor = Color.FromArgb(34, 61, 79);
            lblHorario.Location = new Point(380, 164);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(62, 19);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário";
            // 
            // lblAgendaCliente
            // 
            lblAgendaCliente.AutoSize = true;
            lblAgendaCliente.Font = new Font("Gadugi", 12F);
            lblAgendaCliente.ForeColor = Color.FromArgb(34, 61, 79);
            lblAgendaCliente.Location = new Point(173, 259);
            lblAgendaCliente.Name = "lblAgendaCliente";
            lblAgendaCliente.Size = new Size(57, 19);
            lblAgendaCliente.TabIndex = 1;
            lblAgendaCliente.Text = "Cliente";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Font = new Font("Gadugi", 12F);
            lblPet.ForeColor = Color.FromArgb(34, 61, 79);
            lblPet.Location = new Point(34, 347);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(31, 19);
            lblPet.TabIndex = 1;
            lblPet.Text = "Pet";
            // 
            // txtProfissional
            // 
            txtProfissional.BackColor = Color.AliceBlue;
            txtProfissional.Font = new Font("Arial", 12F);
            txtProfissional.Location = new Point(31, 451);
            txtProfissional.Name = "txtProfissional";
            txtProfissional.Size = new Size(188, 26);
            txtProfissional.TabIndex = 0;
            // 
            // txtServico
            // 
            txtServico.BackColor = Color.AliceBlue;
            txtServico.Font = new Font("Arial", 12F);
            txtServico.Location = new Point(320, 451);
            txtServico.Name = "txtServico";
            txtServico.Size = new Size(188, 26);
            txtServico.TabIndex = 0;
            // 
            // lblProfissional
            // 
            lblProfissional.AutoSize = true;
            lblProfissional.Font = new Font("Gadugi", 12F);
            lblProfissional.ForeColor = Color.FromArgb(34, 61, 79);
            lblProfissional.Location = new Point(31, 429);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(90, 19);
            lblProfissional.TabIndex = 1;
            lblProfissional.Text = "Profissional";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Gadugi", 12F);
            lblServico.ForeColor = Color.FromArgb(34, 61, 79);
            lblServico.Location = new Point(320, 429);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(60, 19);
            lblServico.TabIndex = 1;
            lblServico.Text = "Serviço";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcluir.FlatAppearance.BorderColor = Color.FromArgb(169, 213, 186);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Snow;
            btnExcluir.Location = new Point(398, 723);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // txtAgendaCliente
            // 
            txtAgendaCliente.BackColor = Color.AliceBlue;
            txtAgendaCliente.Font = new Font("Arial", 12F);
            txtAgendaCliente.Location = new Point(179, 281);
            txtAgendaCliente.Name = "txtAgendaCliente";
            txtAgendaCliente.Size = new Size(329, 26);
            txtAgendaCliente.TabIndex = 0;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Gadugi", 12F);
            lblCpf.ForeColor = Color.FromArgb(34, 61, 79);
            lblCpf.Location = new Point(31, 259);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(36, 19);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(34, 61, 79);
            label1.Font = new Font("Arial Rounded MT Bold", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 33);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 1;
            label1.Text = "Agendamento";
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.AliceBlue;
            txtCpf.Font = new Font("Arial", 12F);
            txtCpf.Location = new Point(34, 281);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(121, 26);
            txtCpf.TabIndex = 9;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.AliceBlue;
            txtObservacao.Font = new Font("Arial", 12F);
            txtObservacao.Location = new Point(31, 545);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(477, 96);
            txtObservacao.TabIndex = 10;
            txtObservacao.Text = "";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Font = new Font("Gadugi", 12F);
            lblObservacao.ForeColor = Color.FromArgb(34, 61, 79);
            lblObservacao.Location = new Point(31, 523);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(91, 19);
            lblObservacao.TabIndex = 1;
            lblObservacao.Text = "Observação";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Gadugi", 12F);
            lblEspecie.ForeColor = Color.FromArgb(34, 61, 79);
            lblEspecie.Location = new Point(173, 347);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(60, 19);
            lblEspecie.TabIndex = 1;
            lblEspecie.Text = "Espécie";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Gadugi", 12F);
            lblRaca.ForeColor = Color.FromArgb(34, 61, 79);
            lblRaca.Location = new Point(357, 347);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(42, 19);
            lblRaca.TabIndex = 1;
            lblRaca.Text = "Raça";
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = Color.AliceBlue;
            txtEspecie.Font = new Font("Arial", 12F);
            txtEspecie.Location = new Point(176, 369);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(151, 26);
            txtEspecie.TabIndex = 0;
            // 
            // txtRaca
            // 
            txtRaca.BackColor = Color.AliceBlue;
            txtRaca.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRaca.Location = new Point(357, 369);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(151, 26);
            txtRaca.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 94);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // cmbPet
            // 
            cmbPet.BackColor = Color.AliceBlue;
            cmbPet.Font = new Font("Arial", 12F);
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(34, 369);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(121, 26);
            cmbPet.TabIndex = 12;
            // 
            // AgendamentoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 776);
            Controls.Add(cmbPet);
            Controls.Add(panel1);
            Controls.Add(txtObservacao);
            Controls.Add(txtCpf);
            Controls.Add(pictureBox2);
            Controls.Add(btnExcluir);
            Controls.Add(txtHora);
            Controls.Add(btnSalvar);
            Controls.Add(lblRaca);
            Controls.Add(lblEspecie);
            Controls.Add(lblHorario);
            Controls.Add(lblPet);
            Controls.Add(lblServico);
            Controls.Add(lblCpf);
            Controls.Add(lblAgendaCliente);
            Controls.Add(lblObservacao);
            Controls.Add(lblProfissional);
            Controls.Add(lblData);
            Controls.Add(txtServico);
            Controls.Add(txtProfissional);
            Controls.Add(txtRaca);
            Controls.Add(txtEspecie);
            Controls.Add(txtAgendaCliente);
            Controls.Add(txtDia);
            Name = "AgendamentoHorario";
            Text = "AgendamentoHorario";
            Load += AgendamentoHorario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private TextBox txtAgendaCliente;
        private Label lblCpf;
        private Label label1;
        private PictureBox pictureBox2;
        private MaskedTextBox txtCpf; // Mantido como o principal MaskedTextBox
        private RichTextBox txtObservacao;
        private Label lblObservacao;
        private Label lblEspecie;
        private Label lblRaca;
        private TextBox txtEspecie;
        private TextBox txtRaca;
        private ComboBox cmbPet; // MANTER APENAS ESTA VERSÃO (RESOLVE A AMBIGUIDADE)
        private Panel panel1;
        private PictureBox pictureBox3;

    }
}