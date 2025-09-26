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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cxDia = new ComboBox();
            cxMes = new ComboBox();
            cxAno = new ComboBox();
            GeneroF = new RadioButton();
            GeneroM = new RadioButton();
            Outro = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            btnCadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(218, 85);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(355, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 35);
            label1.TabIndex = 1;
            label1.Text = "Cadastre-se Aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 124);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(218, 200);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(355, 23);
            txtSenha.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 182);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            // 
            // cxDia
            // 
            cxDia.FormattingEnabled = true;
            cxDia.Location = new Point(218, 280);
            cxDia.Name = "cxDia";
            cxDia.Size = new Size(61, 23);
            cxDia.TabIndex = 7;
            // 
            // cxMes
            // 
            cxMes.FormattingEnabled = true;
            cxMes.Location = new Point(297, 280);
            cxMes.Name = "cxMes";
            cxMes.Size = new Size(182, 23);
            cxMes.TabIndex = 8;
            // 
            // cxAno
            // 
            cxAno.FormattingEnabled = true;
            cxAno.Location = new Point(492, 280);
            cxAno.Name = "cxAno";
            cxAno.Size = new Size(81, 23);
            cxAno.TabIndex = 9;
            // 
            // GeneroF
            // 
            GeneroF.BackColor = Color.Ivory;
            GeneroF.Location = new Point(218, 349);
            GeneroF.Name = "GeneroF";
            GeneroF.Size = new Size(104, 24);
            GeneroF.TabIndex = 10;
            GeneroF.TabStop = true;
            GeneroF.Text = "F";
            GeneroF.UseVisualStyleBackColor = false;
            // 
            // GeneroM
            // 
            GeneroM.BackColor = Color.Ivory;
            GeneroM.Location = new Point(344, 349);
            GeneroM.Name = "GeneroM";
            GeneroM.Size = new Size(104, 24);
            GeneroM.TabIndex = 11;
            GeneroM.TabStop = true;
            GeneroM.Text = "M";
            GeneroM.UseVisualStyleBackColor = false;
            // 
            // Outro
            // 
            Outro.BackColor = Color.Ivory;
            Outro.Location = new Point(469, 349);
            Outro.Name = "Outro";
            Outro.Size = new Size(104, 24);
            Outro.TabIndex = 12;
            Outro.TabStop = true;
            Outro.Text = "Outro";
            Outro.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 253);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 13;
            label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 322);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 14;
            label6.Text = "Genêro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(278, 410);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(242, 29);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
      
            // 
            // pictureBox1
            // 
          
            pictureBox1.Location = new Point(12, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 225);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(828, 463);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Outro);
            Controls.Add(GeneroM);
            Controls.Add(GeneroF);
            Controls.Add(cxAno);
            Controls.Add(cxMes);
            Controls.Add(cxDia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "CadastroUsuario";
            Text = "Cadastro Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label3;
        private Label label4;
        private ComboBox cxDia;
        private ComboBox cxMes;
        private ComboBox cxAno;
        private RadioButton GeneroF;
        private RadioButton GeneroM;
        private RadioButton Outro;
        private Label label5;
        private Label label6;
        private Button btnCadastrar;
        private PictureBox pictureBox1;
    }
}


    