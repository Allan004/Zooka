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
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(181, 34);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Cliente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 12F);
            label2.ForeColor = Color.FromArgb(34, 61, 79);
            label2.Location = new Point(38, 118);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 12F);
            label3.ForeColor = Color.FromArgb(34, 61, 79);
            label3.Location = new Point(318, 546);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 12F);
            label4.ForeColor = Color.FromArgb(34, 61, 79);
            label4.Location = new Point(38, 188);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gadugi", 12F);
            label5.ForeColor = Color.FromArgb(34, 61, 79);
            label5.Location = new Point(360, 338);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 4;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gadugi", 12F);
            label6.ForeColor = Color.FromArgb(34, 61, 79);
            label6.Location = new Point(205, 186);
            label6.Name = "label6";
            label6.Size = new Size(30, 19);
            label6.TabIndex = 5;
            label6.Text = "RG";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gadugi", 12F);
            label7.ForeColor = Color.FromArgb(34, 61, 79);
            label7.Location = new Point(205, 261);
            label7.Name = "label7";
            label7.Size = new Size(60, 19);
            label7.TabIndex = 6;
            label7.Text = "Genero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Gadugi", 12F);
            label8.ForeColor = Color.FromArgb(34, 61, 79);
            label8.Location = new Point(38, 410);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 7;
            label8.Text = "CEP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Gadugi", 12F);
            label9.ForeColor = Color.FromArgb(34, 61, 79);
            label9.Location = new Point(38, 480);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 8;
            label9.Text = "Bairro";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Gadugi", 12F);
            label10.ForeColor = Color.FromArgb(34, 61, 79);
            label10.Location = new Point(38, 261);
            label10.Name = "label10";
            label10.Size = new Size(92, 19);
            label10.TabIndex = 9;
            label10.Text = "Nascimento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Gadugi", 12F);
            label11.ForeColor = Color.FromArgb(34, 61, 79);
            label11.Location = new Point(38, 338);
            label11.Name = "label11";
            label11.Size = new Size(47, 19);
            label11.TabIndex = 10;
            label11.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Gadugi", 12F);
            label12.ForeColor = Color.FromArgb(34, 61, 79);
            label12.Location = new Point(38, 546);
            label12.Name = "label12";
            label12.Size = new Size(57, 19);
            label12.TabIndex = 11;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Gadugi", 12F);
            label13.ForeColor = Color.FromArgb(34, 61, 79);
            label13.Location = new Point(180, 410);
            label13.Name = "label13";
            label13.Size = new Size(91, 19);
            label13.TabIndex = 12;
            label13.Text = "Logradouro";
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.AliceBlue;
            txtnome.Font = new Font("Arial", 12F);
            txtnome.Location = new Point(38, 140);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(475, 26);
            txtnome.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.AliceBlue;
            txtemail.Font = new Font("Arial", 12F);
            txtemail.Location = new Point(38, 360);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(284, 26);
            txtemail.TabIndex = 7;
            // 
            // txtlogradouro
            // 
            txtlogradouro.BackColor = Color.AliceBlue;
            txtlogradouro.Font = new Font("Arial", 12F);
            txtlogradouro.Location = new Point(180, 432);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(333, 26);
            txtlogradouro.TabIndex = 9;
            // 
            // txtbairro
            // 
            txtbairro.BackColor = Color.AliceBlue;
            txtbairro.Font = new Font("Arial", 12F);
            txtbairro.Location = new Point(38, 502);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(310, 26);
            txtbairro.TabIndex = 11;
            // 
            // txtcidade
            // 
            txtcidade.BackColor = Color.AliceBlue;
            txtcidade.Font = new Font("Arial", 12F);
            txtcidade.Location = new Point(38, 568);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(257, 26);
            txtcidade.TabIndex = 10;
            // 
            // txtestado
            // 
            txtestado.BackColor = Color.AliceBlue;
            txtestado.Font = new Font("Arial", 12F);
            txtestado.Location = new Point(318, 568);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(195, 26);
            txtestado.TabIndex = 12;
            // 
            // txtdata
            // 
            txtdata.BackColor = Color.AliceBlue;
            txtdata.Font = new Font("Arial", 12F);
            txtdata.Location = new Point(38, 283);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(110, 26);
            txtdata.TabIndex = 2;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = Color.AliceBlue;
            txttelefone.Font = new Font("Arial", 12F);
            txttelefone.Location = new Point(360, 360);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(153, 26);
            txttelefone.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.AliceBlue;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(205, 283);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 26);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtcep
            // 
            txtcep.BackColor = Color.AliceBlue;
            txtcep.Font = new Font("Arial", 12F);
            txtcep.Location = new Point(38, 432);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(107, 26);
            txtcep.TabIndex = 8;
            // 
            // txtcpf
            // 
            txtcpf.BackColor = Color.AliceBlue;
            txtcpf.Font = new Font("Arial", 12F);
            txtcpf.Location = new Point(38, 208);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(124, 26);
            txtcpf.TabIndex = 3;
            // 
            // txtrg
            // 
            txtrg.BackColor = Color.AliceBlue;
            txtrg.Font = new Font("Arial", 12F);
            txtrg.Location = new Point(205, 208);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(119, 26);
            txtrg.TabIndex = 5;
            txtrg.MaskInputRejected += txtrg_MaskInputRejected;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(403, 631);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 21;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 94);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(547, 677);
            Controls.Add(panel1);
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
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}