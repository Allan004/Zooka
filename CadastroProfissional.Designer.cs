using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Zooka
{
    partial class CadastroProfissional
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
            button1 = new Button();
            txtrg = new MaskedTextBox();
            txtcpf = new MaskedTextBox();
            txtcep = new MaskedTextBox();
            comboBox1 = new ComboBox();
            txttelefone = new MaskedTextBox();
            txtdata = new MaskedTextBox();
            txtestado = new TextBox();
            txtcidade = new TextBox();
            txtbairro = new TextBox();
            txtlogradouro = new TextBox();
            txtemail = new TextBox();
            txtnome = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Especialidade = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 118, 40);
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(324, 322);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(191, 64);
            button1.TabIndex = 47;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // txtrg
            // 
            txtrg.Location = new Point(262, 133);
            txtrg.Margin = new Padding(4, 3, 4, 3);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(68, 23);
            txtrg.TabIndex = 32;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(130, 133);
            txtcpf.Margin = new Padding(4, 3, 4, 3);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(75, 23);
            txtcpf.TabIndex = 28;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(128, 216);
            txtcep.Margin = new Padding(4, 3, 4, 3);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(56, 23);
            txtcep.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(449, 171);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 33;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(422, 133);
            txttelefone.Margin = new Padding(4, 3, 4, 3);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(79, 23);
            txttelefone.TabIndex = 29;
            // 
            // txtdata
            // 
            txtdata.Location = new Point(655, 133);
            txtdata.Margin = new Padding(4, 3, 4, 3);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(59, 23);
            txtdata.TabIndex = 25;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(459, 261);
            txtestado.Margin = new Padding(4, 3, 4, 3);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(255, 23);
            txtestado.TabIndex = 45;
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(553, 216);
            txtcidade.Margin = new Padding(4, 3, 4, 3);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(161, 23);
            txtcidade.TabIndex = 42;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(130, 261);
            txtbairro.Margin = new Padding(4, 3, 4, 3);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(270, 23);
            txtbairro.TabIndex = 44;
            // 
            // txtlogradouro
            // 
            txtlogradouro.Location = new Point(263, 216);
            txtlogradouro.Margin = new Padding(4, 3, 4, 3);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(231, 23);
            txtlogradouro.TabIndex = 40;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(130, 176);
            txtemail.Margin = new Padding(4, 3, 4, 3);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(250, 23);
            txtemail.TabIndex = 36;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(130, 94);
            txtnome.Margin = new Padding(4, 3, 4, 3);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(270, 23);
            txtnome.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sans Serif Collection", 8.999999F);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(182, 213);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(86, 41);
            label13.TabIndex = 46;
            label13.Text = "Logradouro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sans Serif Collection", 8.999999F);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(502, 211);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(60, 41);
            label12.TabIndex = 43;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sans Serif Collection", 8.999999F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(78, 171);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 41);
            label11.TabIndex = 41;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sans Serif Collection", 8.999999F);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(529, 128);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 41);
            label10.TabIndex = 39;
            label10.Text = "Data de Nascimento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 8.999999F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(78, 256);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 41);
            label9.TabIndex = 37;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sans Serif Collection", 8.999999F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(80, 211);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 41);
            label8.TabIndex = 35;
            label8.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 8.999999F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(388, 166);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 41);
            label7.TabIndex = 34;
            label7.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 8.999999F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(228, 128);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 41);
            label6.TabIndex = 31;
            label6.Text = "RG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 8.999999F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(361, 128);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 41);
            label5.TabIndex = 30;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 8.999999F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(78, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 41);
            label4.TabIndex = 27;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.999999F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(398, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 41);
            label3.TabIndex = 26;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.999999F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(78, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 23;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(88, 120, 248);
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(277, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 30);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO PROFISIONAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Especialidade
            // 
            Especialidade.AutoSize = true;
            Especialidade.ForeColor = SystemColors.ButtonHighlight;
            Especialidade.Location = new Point(406, 98);
            Especialidade.Name = "Especialidade";
            Especialidade.Size = new Size(81, 15);
            Especialidade.TabIndex = 48;
            Especialidade.Text = "Especialidade:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.InitialImage = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // CadastroProfissional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 120, 248);
            ClientSize = new Size(800, 429);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(Especialidade);
            Controls.Add(button1);
            Controls.Add(txtrg);
            Controls.Add(txtcpf);
            Controls.Add(txtcep);
            Controls.Add(comboBox1);
            Controls.Add(txttelefone);
            Controls.Add(txtdata);
            Controls.Add(txtestado);
            Controls.Add(txtcidade);
            Controls.Add(txtbairro);
            Controls.Add(txtlogradouro);
            Controls.Add(txtemail);
            Controls.Add(txtnome);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroProfissional";
            Text = "CadastroProfissional";
            Load += CadastroProfissional_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtrg;
        private MaskedTextBox txtcpf;
        private MaskedTextBox txtcep;
        private ComboBox comboBox1;
        private MaskedTextBox txttelefone;
        private MaskedTextBox txtdata;
        private TextBox txtestado;
        private TextBox txtcidade;
        private TextBox txtbairro;
        private TextBox txtlogradouro;
        private TextBox txtemail;
        private TextBox txtnome;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Especialidade;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}