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
            lpDay = new FlowLayoutPanel();
            lblDomingo = new Label();
            lblSegunda = new Label();
            lblTerça = new Label();
            lblQuarta = new Label();
            lblQuinta = new Label();
            lblSexta = new Label();
            lblSabado = new Label();
            btnProximo = new Button();
            btnAnterior = new Button();
            lblMesAno = new Label();
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
            lblDomingo.AutoSize = true;
            lblDomingo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomingo.Location = new Point(71, 78);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(96, 25);
            lblDomingo.TabIndex = 1;
            lblDomingo.Text = "Domingo";
            // 
            // lblSegunda
            // 
            lblSegunda.AutoSize = true;
            lblSegunda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSegunda.Location = new Point(340, 78);
            lblSegunda.Name = "lblSegunda";
            lblSegunda.Size = new Size(91, 25);
            lblSegunda.TabIndex = 1;
            lblSegunda.Text = "Segunda";
            // 
            // lblTerça
            // 
            lblTerça.AutoSize = true;
            lblTerça.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTerça.Location = new Point(595, 78);
            lblTerça.Name = "lblTerça";
            lblTerça.Size = new Size(58, 25);
            lblTerça.TabIndex = 1;
            lblTerça.Text = "Terça";
            // 
            // lblQuarta
            // 
            lblQuarta.AutoSize = true;
            lblQuarta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblQuarta.Location = new Point(829, 78);
            lblQuarta.Name = "lblQuarta";
            lblQuarta.Size = new Size(74, 25);
            lblQuarta.TabIndex = 1;
            lblQuarta.Text = "Quarta";
            // 
            // lblQuinta
            // 
            lblQuinta.AutoSize = true;
            lblQuinta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblQuinta.Location = new Point(1065, 78);
            lblQuinta.Name = "lblQuinta";
            lblQuinta.Size = new Size(72, 25);
            lblQuinta.TabIndex = 1;
            lblQuinta.Text = "Quinta";
            // 
            // lblSexta
            // 
            lblSexta.AutoSize = true;
            lblSexta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSexta.Location = new Point(1328, 78);
            lblSexta.Name = "lblSexta";
            lblSexta.Size = new Size(61, 25);
            lblSexta.TabIndex = 1;
            lblSexta.Text = "Sexta";
            // 
            // lblSabado
            // 
            lblSabado.AutoSize = true;
            lblSabado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSabado.Location = new Point(1558, 78);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(79, 25);
            lblSabado.TabIndex = 1;
            lblSabado.Text = "Sábado";
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(1701, 30);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(111, 28);
            btnProximo.TabIndex = 3;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(1558, 30);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(115, 28);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblMesAno
            // 
            lblMesAno.AutoSize = true;
            lblMesAno.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesAno.Location = new Point(537, 9);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(200, 50);
            lblMesAno.TabIndex = 1;
            lblMesAno.Text = "Mês / Ano";
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 1061);
            Controls.Add(btnAnterior);
            Controls.Add(btnProximo);
            Controls.Add(lblSabado);
            Controls.Add(lblSexta);
            Controls.Add(lblQuinta);
            Controls.Add(lblQuarta);
            Controls.Add(lblMesAno);
            Controls.Add(lblTerça);
            Controls.Add(lblSegunda);
            Controls.Add(lblDomingo);
            Controls.Add(lpDay);
            Name = "Agenda";
            Text = "Agenda";
            Load += Agenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel lpDay;
        private Label lblDomingo;
        private Label lblSegunda;
        private Label lblTerça;
        private Label lblQuarta;
        private Label lblQuinta;
        private Label lblSexta;
        private Label lblSabado;
        private Button btnProximo;
        private Button btnAnterior;
        private Label lblMesAno;
    }
}