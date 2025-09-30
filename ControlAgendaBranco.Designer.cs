namespace Zooka
{
    partial class ControlAgendaBranco
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
            lblBranco = new Label();
            SuspendLayout();
            // 
            // lblBranco
            // 
            lblBranco.AutoSize = true;
            lblBranco.Location = new Point(79, 44);
            lblBranco.Name = "lblBranco";
            lblBranco.Size = new Size(19, 15);
            lblBranco.TabIndex = 0;
            lblBranco.Text = "aa";
            // 
            // ControlAgendaBranco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBranco);
            Name = "ControlAgendaBranco";
            Size = new Size(200, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBranco;
    }
}
