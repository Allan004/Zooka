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
            lblStatusAgenda = new Label();
            btnSalvar = new Button();
            txtHora = new TextBox();
            lblHorario = new Label();
            txtAgendaCliente = new TextBox();
            lblAgendaCliente = new Label();
            txtPet = new TextBox();
            lblPet = new Label();
            txtProfissional = new TextBox();
            txtServico = new TextBox();
            lblProfissional = new Label();
            lblServico = new Label();
            lblStatusDia = new Label();
            cmbStatusDia = new ComboBox();
            cmbStatusAgenda = new ComboBox();
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
            // lblStatusAgenda
            // 
            lblStatusAgenda.AutoSize = true;
            lblStatusAgenda.Location = new Point(406, 191);
            lblStatusAgenda.Name = "lblStatusAgenda";
            lblStatusAgenda.Size = new Size(83, 15);
            lblStatusAgenda.TabIndex = 1;
            lblStatusAgenda.Text = "Status Agenda";
            // 
            // btnSalvar
            // 
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
            // txtAgendaCliente
            // 
            txtAgendaCliente.Location = new Point(92, 83);
            txtAgendaCliente.Name = "txtAgendaCliente";
            txtAgendaCliente.Size = new Size(250, 23);
            txtAgendaCliente.TabIndex = 0;
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
            // txtPet
            // 
            txtPet.Location = new Point(94, 139);
            txtPet.Name = "txtPet";
            txtPet.Size = new Size(248, 23);
            txtPet.TabIndex = 0;
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
            // lblStatusDia
            // 
            lblStatusDia.AutoSize = true;
            lblStatusDia.Location = new Point(406, 121);
            lblStatusDia.Name = "lblStatusDia";
            lblStatusDia.Size = new Size(59, 15);
            lblStatusDia.TabIndex = 1;
            lblStatusDia.Text = "Status Dia";
            // 
            // cmbStatusDia
            // 
            cmbStatusDia.FormattingEnabled = true;
            cmbStatusDia.Location = new Point(406, 152);
            cmbStatusDia.Name = "cmbStatusDia";
            cmbStatusDia.Size = new Size(121, 23);
            cmbStatusDia.TabIndex = 4;
            // 
            // cmbStatusAgenda
            // 
            cmbStatusAgenda.FormattingEnabled = true;
            cmbStatusAgenda.Location = new Point(406, 209);
            cmbStatusAgenda.Name = "cmbStatusAgenda";
            cmbStatusAgenda.Size = new Size(121, 23);
            cmbStatusAgenda.TabIndex = 4;
            // 
            // AgendamentoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStatusAgenda);
            Controls.Add(cmbStatusDia);
            Controls.Add(txtHora);
            Controls.Add(btnSalvar);
            Controls.Add(lblStatusDia);
            Controls.Add(lblStatusAgenda);
            Controls.Add(lblHorario);
            Controls.Add(lblPet);
            Controls.Add(lblServico);
            Controls.Add(lblAgendaCliente);
            Controls.Add(lblProfissional);
            Controls.Add(lblData);
            Controls.Add(txtPet);
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
        private Label lblStatusAgenda;
        private Button btnSalvar;
        private TextBox txtHora;
        private Label lblHorario;
        private TextBox txtAgendaCliente;
        private Label lblAgendaCliente;
        private TextBox txtPet;
        private Label lblPet;
        private TextBox txtProfissional;
        private TextBox txtServico;
        private Label lblProfissional;
        private Label lblServico;
        private Label lblStatusDia;
        private ComboBox cmbStatusDia;
        private ComboBox cmbStatusAgenda;
    }
}