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
            txtEvento = new TextBox();
            lblDia = new Label();
            lblEvento = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(92, 105);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(606, 23);
            txtDia.TabIndex = 0;
            // 
            // txtEvento
            // 
            txtEvento.Location = new Point(94, 171);
            txtEvento.Name = "txtEvento";
            txtEvento.Size = new Size(606, 23);
            txtEvento.TabIndex = 0;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(94, 73);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 1;
            lblDia.Text = "Dia";
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Location = new Point(94, 143);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(43, 15);
            lblEvento.TabIndex = 1;
            lblEvento.Text = "Evento";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(703, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // AgendamentoHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblEvento);
            Controls.Add(lblDia);
            Controls.Add(txtEvento);
            Controls.Add(txtDia);
            Name = "AgendamentoHorario";
            Text = "AgendamentoHorario";
            Load += AgendamentoHorario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private TextBox txtEvento;
        private Label lblDia;
        private Label lblEvento;
        private Button btnSalvar;
    }
}