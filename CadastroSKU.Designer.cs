namespace Zooka
{
    partial class CadastroSKU
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
            lblSKU = new Label();
            txtSKU = new TextBox();
            SuspendLayout();
            // 
            // lblSKU
            // 
            lblSKU.BackColor = Color.Transparent;
            lblSKU.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU.ForeColor = Color.MidnightBlue;
            lblSKU.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU.Location = new Point(41, 40);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(53, 25);
            lblSKU.TabIndex = 0;
            lblSKU.Text = "SKU";
            lblSKU.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSKU
            // 
            txtSKU.ForeColor = Color.MidnightBlue;
            txtSKU.Location = new Point(41, 68);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(119, 23);
            txtSKU.TabIndex = 1;
            // 
            // CadastroSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSKU);
            Controls.Add(lblSKU);
            Name = "CadastroSKU";
            Text = "Cadastro de SKU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSKU;
        private TextBox txtSKU;
    }
}