namespace Zooka
{
    partial class CadastroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            txtSenha = new TextBox();
            btnCadastrar = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtConfirmarSenha = new TextBox();
            chkMostrarConfirmarSenha = new CheckBox();
            chkMostrarSenha = new CheckBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(166, 166, 166);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(474, 274);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 16);
            txtSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(550, 388);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(78, 28);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(166, 166, 166);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(474, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 16);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(166, 166, 166);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(474, 158);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(240, 16);
            txtNome.TabIndex = 3;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = Color.FromArgb(166, 166, 166);
            txtConfirmarSenha.BorderStyle = BorderStyle.None;
            txtConfirmarSenha.Location = new Point(474, 338);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(240, 16);
            txtConfirmarSenha.TabIndex = 8;
            // 
            // chkMostrarConfirmarSenha
            // 
            chkMostrarConfirmarSenha.AutoSize = true;
            chkMostrarConfirmarSenha.Location = new Point(726, 340);
            chkMostrarConfirmarSenha.Name = "chkMostrarConfirmarSenha";
            chkMostrarConfirmarSenha.Size = new Size(15, 14);
            chkMostrarConfirmarSenha.TabIndex = 9;
            chkMostrarConfirmarSenha.UseVisualStyleBackColor = true;
            chkMostrarConfirmarSenha.CheckedChanged += chkMostrarConfirmarSenha_CheckedChanged_1;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.AutoSize = true;
            chkMostrarSenha.Location = new Point(725, 276);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(15, 14);
            chkMostrarSenha.TabIndex = 10;
            chkMostrarSenha.UseVisualStyleBackColor = true;
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged_1;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 463);
            Controls.Add(chkMostrarSenha);
            Controls.Add(chkMostrarConfirmarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenha);
            Name = "CadastroUsuario";
            Load += CadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Button btnCadastrar;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtConfirmarSenha;
        private CheckBox chkMostrarConfirmarSenha;
        private CheckBox chkMostrarSenha;
    }
}


    