namespace Zooka
{
    partial class PaginaInicial
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
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel6 = new LinkLabel();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Location = new Point(208, 17);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.White;
            linkLabel2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel2.Location = new Point(438, 17);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(41, 14);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Preços";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.White;
            linkLabel3.Font = new Font("Cambria Math", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel3.Location = new Point(498, -9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(91, 67);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Contate-nos";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.White;
            linkLabel4.LinkColor = Color.DodgerBlue;
            linkLabel4.Location = new Point(528, 17);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(0, 15);
            linkLabel4.TabIndex = 3;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.BackColor = Color.White;
            linkLabel5.Font = new Font("Cambria Math", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel5.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel5.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel5.Location = new Point(593, -8);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(106, 67);
            linkLabel5.TabIndex = 4;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Àrea do cliente";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.BackColor = Color.White;
            linkLabel6.Font = new Font("Cambria Math", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel6.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel6.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel6.Location = new Point(699, -8);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(89, 67);
            linkLabel6.TabIndex = 5;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Profissional";
            // 
            // PaginaInicial
            // 
            AutoScaleMode = AutoScaleMode.None;

            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel6);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "PaginaInicial";
            Text = "PaginaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel6;
    }
}