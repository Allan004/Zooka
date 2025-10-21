namespace Zooka
{
    partial class ControlAgendaDias
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDia = new Label();
            lblDetalheAgenda = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(105, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(27, 19);
            lblDia.TabIndex = 0;
            lblDia.Text = "00";
            // 
            // lblDetalheAgenda
            // 
            lblDetalheAgenda.AutoSize = true;
            lblDetalheAgenda.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalheAgenda.Location = new Point(9, 49);
            lblDetalheAgenda.Name = "lblDetalheAgenda";
            lblDetalheAgenda.Size = new Size(0, 14);
            lblDetalheAgenda.TabIndex = 1;
            // 
            // ControlAgendaDias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDetalheAgenda);
            Controls.Add(lblDia);
            Name = "ControlAgendaDias";
            Size = new Size(238, 170);

            Click += ControleAgendaDias;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblDetalheAgenda;
        private System.Windows.Forms.Timer timer1;
    }
}
