namespace Zooka
{
    partial class ResetarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetarSenha));
            txtASenha = new TextBox();
            txtASenhaC = new TextBox();
            mostrarSenhaUm = new CheckBox();
            MostarSenhaDois = new CheckBox();
            btnSalvarSenha = new Button();
            SuspendLayout();
            // 
            // txtASenha
            // 
            txtASenha.BackColor = Color.AliceBlue;
            txtASenha.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtASenha.ForeColor = Color.MidnightBlue;
            txtASenha.Location = new Point(37, 233);
            txtASenha.Multiline = true;
            txtASenha.Name = "txtASenha";
            txtASenha.Size = new Size(312, 23);
            txtASenha.TabIndex = 4;
            txtASenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtASenhaC
            // 
            txtASenhaC.BackColor = Color.AliceBlue;
            txtASenhaC.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtASenhaC.ForeColor = Color.MidnightBlue;
            txtASenhaC.Location = new Point(37, 308);
            txtASenhaC.Multiline = true;
            txtASenhaC.Name = "txtASenhaC";
            txtASenhaC.Size = new Size(312, 23);
            txtASenhaC.TabIndex = 5;
            txtASenhaC.TextAlign = HorizontalAlignment.Center;
            // 
            // mostrarSenhaUm
            // 
            mostrarSenhaUm.AutoSize = true;
            mostrarSenhaUm.BackColor = SystemColors.ButtonHighlight;
            mostrarSenhaUm.Location = new Point(355, 237);
            mostrarSenhaUm.Name = "mostrarSenhaUm";
            mostrarSenhaUm.Size = new Size(15, 14);
            mostrarSenhaUm.TabIndex = 10;
            mostrarSenhaUm.UseVisualStyleBackColor = false;
            // 
            // MostarSenhaDois
            // 
            MostarSenhaDois.AutoSize = true;
            MostarSenhaDois.BackColor = SystemColors.ButtonHighlight;
            MostarSenhaDois.Location = new Point(355, 313);
            MostarSenhaDois.Name = "MostarSenhaDois";
            MostarSenhaDois.Size = new Size(15, 14);
            MostarSenhaDois.TabIndex = 11;
            MostarSenhaDois.UseVisualStyleBackColor = false;
            // 
            // btnSalvarSenha
            // 
            btnSalvarSenha.BackColor = Color.Transparent;
            btnSalvarSenha.BackgroundImage = (Image)resources.GetObject("btnSalvarSenha.BackgroundImage");
            btnSalvarSenha.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvarSenha.FlatAppearance.BorderColor = Color.Red;
            btnSalvarSenha.FlatAppearance.BorderSize = 0;
            btnSalvarSenha.FlatStyle = FlatStyle.Flat;
            btnSalvarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarSenha.ForeColor = Color.Transparent;
            btnSalvarSenha.Location = new Point(143, 369);
            btnSalvarSenha.Name = "btnSalvarSenha";
            btnSalvarSenha.Size = new Size(110, 34);
            btnSalvarSenha.TabIndex = 13;
            btnSalvarSenha.Text = "Salvar";
            btnSalvarSenha.UseVisualStyleBackColor = false;
            btnSalvarSenha.Click += btnSalvarSenha_Click_1;
            // 
            // ResetarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarSenha);
            Controls.Add(MostarSenhaDois);
            Controls.Add(mostrarSenhaUm);
            Controls.Add(txtASenhaC);
            Controls.Add(txtASenha);
            ForeColor = Color.DarkSlateBlue;
            Name = "ResetarSenha";
            Text = "AlterarSenha";
            Load += ResetarSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtASenha;
        private TextBox txtASenhaC;
        private CheckBox mostrarSenhaUm;
        private CheckBox MostarSenhaDois;
        private Button btnSalvarSenha;
    }
}