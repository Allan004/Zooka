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
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(92, 27);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(250, 23);
            txtDia.TabIndex = 0;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(92, 9);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.FlatAppearance.BorderColor = Color.Red;
            btnSalvar.FlatAppearance.BorderSize = 7;
            btnSalvar.Location = new Point(703, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(92, 196);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(250, 23);
            txtHora.TabIndex = 3;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(94, 178);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(47, 15);
            lblHorario.TabIndex = 1;
            lblHorario.Text = "Horário";
            // 
            // lblAgendaCliente
            // 
            lblAgendaCliente.AutoSize = true;
            lblAgendaCliente.Location = new Point(92, 65);
            lblAgendaCliente.Name = "lblAgendaCliente";
            lblAgendaCliente.Size = new Size(44, 15);
            lblAgendaCliente.TabIndex = 1;
            lblAgendaCliente.Text = "Cliente";
            // 
            // lblPet
            // 
            lblPet.AutoSize = true;
            lblPet.Location = new Point(94, 121);
            lblPet.Name = "lblPet";
            lblPet.Size = new Size(24, 15);
            lblPet.TabIndex = 1;
            lblPet.Text = "Pet";
            // 
            // txtProfissional
            // 
            txtProfissional.Location = new Point(406, 27);
            txtProfissional.Name = "txtProfissional";
            txtProfissional.Size = new Size(250, 23);
            txtProfissional.TabIndex = 0;
            // 
            // txtServico
            // 
            txtServico.Location = new Point(406, 83);
            txtServico.Name = "txtServico";
            txtServico.Size = new Size(250, 23);
            txtServico.TabIndex = 0;
            // 
            // lblProfissional
            // 
            lblProfissional.AutoSize = true;
            lblProfissional.Location = new Point(406, 9);
            lblProfissional.Name = "lblProfissional";
            lblProfissional.Size = new Size(68, 15);
            lblProfissional.TabIndex = 1;
            lblProfissional.Text = "Profissional";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Location = new Point(406, 65);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(45, 15);
            lblServico.TabIndex = 1;
            lblServico.Text = "Serviço";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(581, 398);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // cmbPet
            // 
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(92, 139);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(121, 23);
            cmbPet.TabIndex = 6;
            // 
            // txtAgendaCliente
            // 
            txtAgendaCliente.Location = new Point(92, 83);
            txtAgendaCliente.Name = "txtAgendaCliente";
            txtAgendaCliente.Size = new Size(250, 23);
            txtAgendaCliente.TabIndex = 0;
            txtAgendaCliente.TextChanged += txtAgendaCliente_TextChanged;
            // 
            // AgendamentoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPet);
            Controls.Add(btnExcluir);
            Controls.Add(txtHora);
            Controls.Add(btnSalvar);
            Controls.Add(lblHorario);
            Controls.Add(lblPet);
            Controls.Add(lblServico);
            Controls.Add(lblAgendaCliente);
            Controls.Add(lblProfissional);
            Controls.Add(lblData);
            Controls.Add(txtServico);
            Controls.Add(txtProfissional);
            Controls.Add(txtAgendaCliente);
            Controls.Add(txtDia);
            Name = "AgendamentoHorario";
            Text = "AgendamentoHorario";
            Load += AgendamentoHorario_Load;
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
    }
}