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
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            button1.Location = new Point(827, 395);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 47;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // txtrg
            // 
            txtrg.BackColor = Color.AliceBlue;
            txtrg.Font = new Font("Arial", 12F);
            txtrg.Location = new Point(272, 193);
            txtrg.Margin = new Padding(4, 3, 4, 3);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(175, 26);
            txtrg.TabIndex = 32;
            // 
            // txtcpf
            // 
            txtcpf.BackColor = Color.AliceBlue;
            txtcpf.Font = new Font("Arial", 12F);
            txtcpf.Location = new Point(85, 193);
            txtcpf.Margin = new Padding(4, 3, 4, 3);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(116, 26);
            txtcpf.TabIndex = 28;
            // 
            // txtcep
            // 
            txtcep.BackColor = Color.AliceBlue;
            txtcep.Font = new Font("Arial", 12F);
            txtcep.Location = new Point(85, 285);
            txtcep.Margin = new Padding(4, 3, 4, 3);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(116, 26);
            txtcep.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.AliceBlue;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Arial", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(611, 237);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 26);
            comboBox1.TabIndex = 33;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = Color.AliceBlue;
            txttelefone.Font = new Font("Arial", 12F);
            txttelefone.Location = new Point(611, 194);
            txttelefone.Margin = new Padding(4, 3, 4, 3);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(115, 26);
            txttelefone.TabIndex = 29;
            txttelefone.MaskInputRejected += txttelefone_MaskInputRejected;
            // 
            // txtdata
            // 
            txtdata.BackColor = Color.AliceBlue;
            txtdata.BorderStyle = BorderStyle.None;
            txtdata.Font = new Font("Arial", 12F);
            txtdata.Location = new Point(841, 191);
            txtdata.Margin = new Padding(4, 3, 4, 3);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(96, 19);
            txtdata.TabIndex = 25;
            // 
            // txtestado
            // 
            txtestado.BackColor = Color.AliceBlue;
            txtestado.Font = new Font("Arial", 12F);
            txtestado.Location = new Point(611, 327);
            txtestado.Margin = new Padding(4, 3, 4, 3);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(326, 26);
            txtestado.TabIndex = 45;
            // 
            // txtcidade
            // 
            txtcidade.BackColor = Color.AliceBlue;
            txtcidade.Font = new Font("Arial", 12F);
            txtcidade.Location = new Point(767, 284);
            txtcidade.Margin = new Padding(4, 3, 4, 3);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(170, 26);
            txtcidade.TabIndex = 42;
            txtcidade.TextChanged += txtcidade_TextChanged;
            // 
            // txtbairro
            // 
            txtbairro.BackColor = Color.AliceBlue;
            txtbairro.Font = new Font("Arial", 12F);
            txtbairro.Location = new Point(85, 328);
            txtbairro.Margin = new Padding(4, 3, 4, 3);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(362, 26);
            txtbairro.TabIndex = 44;
            // 
            // txtlogradouro
            // 
            txtlogradouro.BackColor = Color.AliceBlue;
            txtlogradouro.Font = new Font("Arial", 12F);
            txtlogradouro.Location = new Point(386, 284);
            txtlogradouro.Margin = new Padding(4, 3, 4, 3);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(301, 26);
            txtlogradouro.TabIndex = 40;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.AliceBlue;
            txtemail.Font = new Font("Arial", 12F);
            txtemail.Location = new Point(85, 238);
            txtemail.Margin = new Padding(4, 3, 4, 3);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(362, 26);
            txtemail.TabIndex = 36;
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.AliceBlue;
            txtnome.Font = new Font("Arial", 12F);
            txtnome.Location = new Point(85, 148);
            txtnome.Margin = new Padding(4, 3, 4, 3);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(362, 26);
            txtnome.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Gadugi", 12F);
            label13.ForeColor = Color.FromArgb(34, 61, 79);
            label13.Location = new Point(281, 284);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(94, 19);
            label13.TabIndex = 46;
            label13.Text = "Logradouro:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Gadugi", 12F);
            label12.ForeColor = Color.FromArgb(34, 61, 79);
            label12.Location = new Point(699, 287);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(60, 19);
            label12.TabIndex = 43;
            label12.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Gadugi", 12F);
            label11.ForeColor = Color.FromArgb(34, 61, 79);
            label11.Location = new Point(27, 241);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(50, 19);
            label11.TabIndex = 41;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Gadugi", 12F);
            label10.ForeColor = Color.FromArgb(34, 61, 79);
            label10.Location = new Point(734, 192);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 39;
            label10.Text = "Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Gadugi", 12F);
            label9.ForeColor = Color.FromArgb(34, 61, 79);
            label9.Location = new Point(23, 331);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 19);
            label9.TabIndex = 37;
            label9.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Gadugi", 12F);
            label8.ForeColor = Color.FromArgb(34, 61, 79);
            label8.Location = new Point(38, 288);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 19);
            label8.TabIndex = 35;
            label8.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gadugi", 12F);
            label7.ForeColor = Color.FromArgb(34, 61, 79);
            label7.Location = new Point(540, 238);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 34;
            label7.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gadugi", 12F);
            label6.ForeColor = Color.FromArgb(34, 61, 79);
            label6.Location = new Point(231, 196);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 19);
            label6.TabIndex = 31;
            label6.Text = "RG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gadugi", 12F);
            label5.ForeColor = Color.FromArgb(34, 61, 79);
            label5.Location = new Point(532, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 30;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 12F);
            label4.ForeColor = Color.FromArgb(34, 61, 79);
            label4.Location = new Point(38, 196);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 27;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 12F);
            label3.ForeColor = Color.FromArgb(34, 61, 79);
            label3.Location = new Point(545, 330);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 26;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 12F);
            label2.ForeColor = Color.FromArgb(34, 61, 79);
            label2.Location = new Point(22, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 23;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(34, 61, 79);
            label1.Font = new Font("Arial Rounded MT Bold", 20F);
            label1.ForeColor = Color.FromArgb(215, 122, 40);
            label1.Location = new Point(173, 30);
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
            Especialidade.BackColor = Color.Transparent;
            Especialidade.Font = new Font("Gadugi", 12F);
            Especialidade.ForeColor = Color.FromArgb(34, 61, 79);
            Especialidade.Location = new Point(498, 151);
            Especialidade.Name = "Especialidade";
            Especialidade.Size = new Size(105, 19);
            Especialidade.TabIndex = 48;
            Especialidade.Text = "Especialidade:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(611, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 26);
            textBox1.TabIndex = 49;
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 94);
            panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // CadastroProfissional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(975, 452);
            Controls.Add(button1);
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
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CadastroProfissional";
            Text = "CadastroProfissional";
            Load += CadastroProfissional_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
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
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}