namespace Zooka
{
    partial class LoginUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.LinkLabel linkCadastrar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox SenhaLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            linkCadastrar = new LinkLabel();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            SenhaLogin = new CheckBox();
            linkLabel1 = new LinkLabel();
            btnEntrar = new Button();
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
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(166, 166, 166);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Location = new Point(58, 209);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(240, 16);
            txtLogin.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(166, 166, 166);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Location = new Point(58, 293);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 16);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // SenhaLogin
            // 
            SenhaLogin.AutoSize = true;
            SenhaLogin.BackColor = SystemColors.ButtonHighlight;
            SenhaLogin.Location = new Point(329, 295);
            SenhaLogin.Name = "SenhaLogin";
            SenhaLogin.Size = new Size(15, 14);
            SenhaLogin.TabIndex = 9;
            SenhaLogin.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.White;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(196, 321);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueceu a senha?";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(112, 356);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(127, 28);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // LoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Blue_Flat_Color_UI_Login_Page_Desktop_Prototype;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(linkLabel1);
            Controls.Add(SenhaLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(linkCadastrar);
            Name = "LoginUsuario";
            Text = "LoginUsuario";
            Load += LoginUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnEntrar;
    }
}
