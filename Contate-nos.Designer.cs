using Zooka.Properties;

namespace Zooka
{
    partial class Contate_nos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contate_nos));
            label1 = new Label();
            BtnEntrar = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            SeuNome = new TextBox();
            SeuEmail = new TextBox();
            SeuTelefone = new TextBox();
            SuaMensagem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 148);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackColor = Color.FromArgb(255, 128, 0);
            BtnEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BtnEntrar.FlatAppearance.BorderSize = 0;
            BtnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            BtnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Location = new Point(464, 350);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(87, 24);
            BtnEntrar.TabIndex = 8;
            BtnEntrar.Text = "Enviar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(12, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 14);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel2.Location = new Point(80, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(41, 14);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Preços";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel3.Location = new Point(227, 27);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(84, 14);
            linkLabel3.TabIndex = 11;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Àrea do cliente";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel4.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel4.Location = new Point(338, 27);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(67, 14);
            linkLabel4.TabIndex = 12;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Profissional";
            // 
            // SeuNome
            // 
            SeuNome.BackColor = Color.White;
            SeuNome.Location = new Point(470, 147);
            SeuNome.Name = "SeuNome";
            SeuNome.Size = new Size(229, 23);
            SeuNome.TabIndex = 13;
            // 
            // SeuEmail
            // 
            SeuEmail.Location = new Point(466, 195);
            SeuEmail.Name = "SeuEmail";
            SeuEmail.Size = new Size(229, 23);
            SeuEmail.TabIndex = 14;
            // 
            // SeuTelefone
            // 
            SeuTelefone.Location = new Point(471, 244);
            SeuTelefone.Name = "SeuTelefone";
            SeuTelefone.Size = new Size(229, 23);
            SeuTelefone.TabIndex = 15;
            // 
            // SuaMensagem
            // 
            SuaMensagem.Location = new Point(471, 293);
            SuaMensagem.Multiline = true;
            SuaMensagem.Name = "SuaMensagem";
            SuaMensagem.Size = new Size(225, 42);
            SuaMensagem.TabIndex = 16;
            // 
            // Contate_nos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(SuaMensagem);
            Controls.Add(SeuTelefone);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(BtnEntrar);
            Controls.Add(label1);
            Controls.Add(SeuNome);
            Controls.Add(SeuEmail);
            Name = "Contate_nos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnEntrar;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private TextBox SeuNome;
        private TextBox SeuEmail;
        private TextBox SeuTelefone;
        private TextBox SuaMensagem;
    }
}