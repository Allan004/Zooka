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
            lblControleAgendaBrancoDia = new Label();
            SuspendLayout();
            // 
            // lblControleAgendaBrancoDia
            // 
            lblControleAgendaBrancoDia.AutoSize = true;
            lblControleAgendaBrancoDia.Location = new Point(103, 3);
            lblControleAgendaBrancoDia.Name = "lblControleAgendaBrancoDia";
            lblControleAgendaBrancoDia.Size = new Size(19, 15);
            lblControleAgendaBrancoDia.TabIndex = 0;
            lblControleAgendaBrancoDia.Text = "00";
            // 
            // ControlAgendaBranco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblControleAgendaBrancoDia);
            Name = "ControlAgendaBranco";
            Size = new Size(238, 170);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblControleAgendaBrancoDia;
    }
}
