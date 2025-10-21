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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProfissional));
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
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 241, 201);

            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(346, 432);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(438, 95);
            button1.TabIndex = 47;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // txtrg
            // 
            txtrg.BorderStyle = BorderStyle.None;
            txtrg.Font = new Font("Segoe UI", 13F);
            txtrg.Location = new Point(375, 212);
            txtrg.Margin = new Padding(4, 3, 4, 3);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(175, 24);
            txtrg.TabIndex = 32;
            // 
            // txtcpf
            // 
            txtcpf.BorderStyle = BorderStyle.None;
            txtcpf.Font = new Font("Segoe UI", 13F);
            txtcpf.Location = new Point(188, 212);
            txtcpf.Margin = new Padding(4, 3, 4, 3);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(116, 24);
            txtcpf.TabIndex = 28;
            // 
            // txtcep
            // 
            txtcep.BorderStyle = BorderStyle.None;
            txtcep.Font = new Font("Segoe UI", 13F);
            txtcep.Location = new Point(188, 304);
            txtcep.Margin = new Padding(4, 3, 4, 3);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(179, 24);
            txtcep.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(714, 256);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 23);
            comboBox1.TabIndex = 33;
            // 
            // txttelefone
            // 
            txttelefone.BorderStyle = BorderStyle.None;
            txttelefone.Font = new Font("Segoe UI", 13F);
            txttelefone.Location = new Point(714, 213);
            txttelefone.Margin = new Padding(4, 3, 4, 3);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(115, 24);
            txttelefone.TabIndex = 29;
            txttelefone.MaskInputRejected += txttelefone_MaskInputRejected;
            // 
            // txtdata
            // 
            txtdata.BorderStyle = BorderStyle.None;
            txtdata.Font = new Font("Segoe UI", 13F);
            txtdata.Location = new Point(944, 210);
            txtdata.Margin = new Padding(4, 3, 4, 3);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(96, 24);
            txtdata.TabIndex = 25;
            // 
            // txtestado
            // 
            txtestado.BorderStyle = BorderStyle.None;
            txtestado.Font = new Font("Segoe UI", 13F);
            txtestado.Location = new Point(697, 346);
            txtestado.Margin = new Padding(4, 3, 4, 3);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(343, 24);
            txtestado.TabIndex = 45;
            // 
            // txtcidade
            // 
            txtcidade.BorderStyle = BorderStyle.None;
            txtcidade.Font = new Font("Segoe UI", 13F);
            txtcidade.Location = new Point(870, 303);
            txtcidade.Margin = new Padding(4, 3, 4, 3);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(170, 24);
            txtcidade.TabIndex = 42;
            txtcidade.TextChanged += txtcidade_TextChanged;
            // 
            // txtbairro
            // 
            txtbairro.BorderStyle = BorderStyle.None;
            txtbairro.Font = new Font("Segoe UI", 13F);
            txtbairro.Location = new Point(188, 347);
            txtbairro.Margin = new Padding(4, 3, 4, 3);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(362, 24);
            txtbairro.TabIndex = 44;
            // 
            // txtlogradouro
            // 
            txtlogradouro.BorderStyle = BorderStyle.None;
            txtlogradouro.Font = new Font("Segoe UI", 13F);
            txtlogradouro.Location = new Point(489, 303);
            txtlogradouro.Margin = new Padding(4, 3, 4, 3);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(301, 24);
            txtlogradouro.TabIndex = 40;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Segoe UI", 13F);
            txtemail.Location = new Point(188, 257);
            txtemail.Margin = new Padding(4, 3, 4, 3);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(362, 24);
            txtemail.TabIndex = 36;
            // 
            // txtnome
            // 
            txtnome.BorderStyle = BorderStyle.None;
            txtnome.Font = new Font("Segoe UI", 13F);
            txtnome.Location = new Point(188, 167);
            txtnome.Margin = new Padding(4, 3, 4, 3);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(362, 24);
            txtnome.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 241, 201);
            label13.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(384, 303);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(106, 23);
            label13.TabIndex = 46;
            label13.Text = "Logradouro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 241, 201);
            label12.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(798, 303);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 23);
            label12.TabIndex = 43;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 241, 201);
            label11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(127, 257);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 41;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 241, 201);
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(837, 211);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 23);
            label10.TabIndex = 39;
            label10.Text = "Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 241, 201);
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(127, 347);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 37;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 241, 201);
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(127, 304);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 35;
            label8.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 241, 201);
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(587, 257);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 34;
            label7.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 241, 201);
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(330, 212);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 23);
            label6.TabIndex = 31;
            label6.Text = "RG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 241, 201);
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(587, 212);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 30;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 241, 201);
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(127, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 27;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 241, 201);
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(587, 347);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 26;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 241, 201);
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(127, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 23;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 241, 201);
            label1.Font = new Font("Arial Rounded MT Bold", 30F);
            label1.ForeColor = Color.FromArgb(215, 122, 40);
            label1.Location = new Point(270, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(635, 43);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO PROFISIONAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Especialidade
            // 
            Especialidade.AutoSize = true;
            Especialidade.BackColor = Color.FromArgb(255, 241, 201);
            Especialidade.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            Especialidade.ForeColor = SystemColors.ActiveCaptionText;
            Especialidade.Location = new Point(587, 167);
            Especialidade.Name = "Especialidade";
            Especialidade.Size = new Size(121, 23);
            Especialidade.TabIndex = 48;
            Especialidade.Text = "Especialidade:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(714, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 24);
            textBox1.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 241, 201);
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.InitialImage = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.Location = new Point(47, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(251, 228, 178);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(21, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1099, 556);
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // CadastroProfissional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(1147, 580);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(Especialidade);
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
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroProfissional";
            Text = "CadastroProfissional";
            Load += CadastroProfissional_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
    }
}