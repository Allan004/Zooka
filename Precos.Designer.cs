namespace Zooka
{
    partial class Precos
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
            btnCadastrar = new Button();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(265, 367);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(121, 22);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Adiquirir";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(442, 367);
            button1.Name = "button1";
            button1.Size = new Size(121, 22);
            button1.TabIndex = 9;
            button1.Text = "Adiquirir";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(619, 367);
            button2.Name = "button2";
            button2.Size = new Size(121, 22);
            button2.TabIndex = 10;
            button2.Text = "Adiquirir";
            button2.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.DisabledLinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(302, 42);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel3.Location = new Point(522, 42);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(86, 15);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Àrea do cliente";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.White;
            linkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel4.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel4.Location = new Point(674, 42);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(68, 15);
            linkLabel4.TabIndex = 14;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Profissional";
            // 
            // Precos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ccc;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCadastrar);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Precos";
            Text = "Precos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
    }
}