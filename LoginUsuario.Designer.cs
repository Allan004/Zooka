namespace Zooka
{
    partial class LoginUsuario
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
            linkCadastrar = new LinkLabel();
            txtLoginUsuario = new TextBox();
            txtSenhaLogin = new TextBox();
            btnCadastrar = new Button();
            senhaLogin = new CheckBox();
            SuspendLayout();
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.BackColor = SystemColors.ButtonHighlight;
            linkCadastrar.LinkColor = Color.DodgerBlue;
            linkCadastrar.Location = new Point(206, 147);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(69, 15);
            linkCadastrar.TabIndex = 0;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastre-se";
            linkCadastrar.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.BackColor = Color.FromArgb(166, 166, 166);
            txtLoginUsuario.BorderStyle = BorderStyle.None;
            txtLoginUsuario.Location = new Point(58, 209);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(240, 16);
            txtLoginUsuario.TabIndex = 4;
            txtLoginUsuario.TextChanged += txtLoginUsuario_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.FromArgb(166, 166, 166);
            txtSenhaLogin.BorderStyle = BorderStyle.None;
            txtSenhaLogin.Location = new Point(58, 293);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(240, 16);
            txtSenhaLogin.TabIndex = 5;
            txtSenhaLogin.TextChanged += txtSenhaLogin_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(110, 357);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(127, 28);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Entrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // senhaLogin
            // 
            senhaLogin.AutoSize = true;
            senhaLogin.BackColor = SystemColors.ButtonHighlight;
            senhaLogin.Location = new Point(329, 295);
            senhaLogin.Name = "senhaLogin";
            senhaLogin.Size = new Size(15, 14);
            senhaLogin.TabIndex = 9;
            senhaLogin.UseVisualStyleBackColor = false;
            senhaLogin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaLogin);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtLoginUsuario);
            Controls.Add(linkCadastrar);
            Name = "LoginUsuario";
            Text = "LoginUsuario";
            Load += LoginUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkCadastrar;
        private TextBox txtLoginUsuario;
        private TextBox txtSenhaLogin;
        private Button btnCadastrar;
        private CheckBox senhaLogin;
    }
}