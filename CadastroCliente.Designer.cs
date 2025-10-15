namespace Zooka
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtnome = new TextBox();
            txtemail = new TextBox();
            txtlogradouro = new TextBox();
            txtbairro = new TextBox();
            txtcidade = new TextBox();
            txtestado = new TextBox();
            txtdata = new MaskedTextBox();
            txttelefone = new MaskedTextBox();
            comboBox1 = new ComboBox();
            txtcep = new MaskedTextBox();
            txtcpf = new MaskedTextBox();
            txtrg = new MaskedTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 241, 201);
            label1.Font = new Font("Arial Rounded MT Bold", 30F);
            label1.ForeColor = Color.FromArgb(215, 122, 40);
            label1.Location = new Point(345, 26);
            label1.Name = "label1";
            label1.Size = new Size(437, 46);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 241, 201);
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(180, 160);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 241, 201);
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(563, 340);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 241, 201);
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(180, 205);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 3;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 241, 201);
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(379, 206);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 241, 201);
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(563, 206);
            label6.Name = "label6";
            label6.Size = new Size(38, 23);
            label6.TabIndex = 5;
            label6.Text = "RG:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 241, 201);
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(180, 250);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 6;
            label7.Text = "Genero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 241, 201);
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(791, 250);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 7;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 241, 201);
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(180, 340);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 8;
            label9.Text = "Bairro:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 241, 201);
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(564, 250);
            label10.Name = "label10";
            label10.Size = new Size(105, 23);
            label10.TabIndex = 9;
            label10.Text = "Nascimento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 241, 201);
            label11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(563, 160);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 10;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 241, 201);
            label12.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(180, 295);
            label12.Name = "label12";
            label12.Size = new Size(68, 23);
            label12.TabIndex = 11;
            label12.Text = "Cidade:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 241, 201);
            label13.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(563, 295);
            label13.Name = "label13";
            label13.Size = new Size(106, 23);
            label13.TabIndex = 12;
            label13.Text = "Logradouro:";
            // 
            // txtnome
            // 
            txtnome.BorderStyle = BorderStyle.None;
            txtnome.Font = new Font("Segoe UI", 13F);
            txtnome.Location = new Point(247, 161);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(310, 24);
            txtnome.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Segoe UI", 13F);
            txtemail.Location = new Point(675, 160);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(284, 24);
            txtemail.TabIndex = 7;
            // 
            // txtlogradouro
            // 
            txtlogradouro.BorderStyle = BorderStyle.None;
            txtlogradouro.Font = new Font("Segoe UI", 13F);
            txtlogradouro.Location = new Point(675, 295);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(284, 24);
            txtlogradouro.TabIndex = 9;
            // 
            // txtbairro
            // 
            txtbairro.BorderStyle = BorderStyle.None;
            txtbairro.Font = new Font("Segoe UI", 13F);
            txtbairro.Location = new Point(247, 340);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(310, 24);
            txtbairro.TabIndex = 11;
            // 
            // txtcidade
            // 
            txtcidade.BorderStyle = BorderStyle.None;
            txtcidade.Font = new Font("Segoe UI", 13F);
            txtcidade.Location = new Point(247, 295);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(310, 24);
            txtcidade.TabIndex = 10;
            // 
            // txtestado
            // 
            txtestado.BorderStyle = BorderStyle.None;
            txtestado.Font = new Font("Segoe UI", 13F);
            txtestado.Location = new Point(675, 340);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(284, 24);
            txtestado.TabIndex = 12;
            // 
            // txtdata
            // 
            txtdata.BorderStyle = BorderStyle.None;
            txtdata.Font = new Font("Segoe UI", 13F);
            txtdata.Location = new Point(675, 250);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(110, 24);
            txtdata.TabIndex = 2;
            // 
            // txttelefone
            // 
            txttelefone.BorderStyle = BorderStyle.None;
            txttelefone.Font = new Font("Segoe UI", 13F);
            txttelefone.Location = new Point(466, 206);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(91, 24);
            txttelefone.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(249, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtcep
            // 
            txtcep.BorderStyle = BorderStyle.None;
            txtcep.Font = new Font("Segoe UI", 13F);
            txtcep.Location = new Point(852, 250);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(107, 24);
            txtcep.TabIndex = 8;
            // 
            // txtcpf
            // 
            txtcpf.BorderStyle = BorderStyle.None;
            txtcpf.Font = new Font("Segoe UI", 13F);
            txtcpf.Location = new Point(249, 206);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(124, 24);
            txtcpf.TabIndex = 3;
            // 
            // txtrg
            // 
            txtrg.BorderStyle = BorderStyle.None;
            txtrg.Font = new Font("Segoe UI", 13F);
            txtrg.Location = new Point(675, 204);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(162, 24);
            txtrg.TabIndex = 5;
            txtrg.MaskInputRejected += txtrg_MaskInputRejected;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 241, 201);
            button1.BackgroundImage = Properties.Resources.zabumba1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(346, 432);
            button1.Name = "button1";
            button1.Size = new Size(438, 95);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(251, 228, 178);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(24, 12);
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
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(1147, 580);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
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
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Txtdata_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtnome;
        private TextBox txtemail;
        private TextBox txtlogradouro;
        private TextBox txtbairro;
        private TextBox txtcidade;
        private TextBox txtestado;
        private MaskedTextBox txtdata;
        private MaskedTextBox txttelefone;
        private ComboBox comboBox1;
        private MaskedTextBox txtcep;
        private MaskedTextBox txtcpf;
        private MaskedTextBox txtrg;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
    }
}