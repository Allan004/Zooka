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
            lblDia = new Label();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(26, 17);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(28, 21);
            lblDia.TabIndex = 0;
            lblDia.Text = "00";
            // 
            // ControleAgendaDias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDia);
            Name = "ControleAgendaDias";
            Size = new Size(200, 100);
            //Load += ControleAgendaDias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
    }
}
