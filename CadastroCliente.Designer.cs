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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 6);
            label1.Name = "label1";
            label1.Size = new Size(214, 68);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.999999F);
            label2.Location = new Point(96, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.999999F);
            label3.Location = new Point(424, 310);
            label3.Name = "label3";
            label3.Size = new Size(59, 41);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 8.999999F);
            label4.Location = new Point(96, 121);
            label4.Name = "label4";
            label4.Size = new Size(42, 41);
            label4.TabIndex = 3;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 8.999999F);
            label5.Location = new Point(424, 116);
            label5.Name = "label5";
            label5.Size = new Size(69, 41);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 8.999999F);
            label6.Location = new Point(96, 167);
            label6.Name = "label6";
            label6.Size = new Size(37, 41);
            label6.TabIndex = 5;
            label6.Text = "RG:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sans Serif Collection", 8.999999F);
            label7.Location = new Point(424, 166);
            label7.Name = "label7";
            label7.Size = new Size(63, 41);
            label7.TabIndex = 6;
            label7.Text = "Genero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sans Serif Collection", 8.999999F);
            label8.Location = new Point(424, 209);
            label8.Name = "label8";
            label8.Size = new Size(43, 41);
            label8.TabIndex = 7;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 8.999999F);
            label9.Location = new Point(96, 310);
            label9.Name = "label9";
            label9.Size = new Size(56, 41);
            label9.TabIndex = 8;
            label9.Text = "Bairro:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sans Serif Collection", 8.999999F);
            label10.Location = new Point(424, 74);
            label10.Name = "label10";
            label10.Size = new Size(130, 41);
            label10.TabIndex = 9;
            label10.Text = "Data de Nascimento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sans Serif Collection", 8.999999F);
            label11.Location = new Point(96, 209);
            label11.Name = "label11";
            label11.Size = new Size(52, 41);
            label11.TabIndex = 10;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sans Serif Collection", 8.999999F);
            label12.Location = new Point(424, 256);
            label12.Name = "label12";
            label12.Size = new Size(60, 41);
            label12.TabIndex = 11;
            label12.Text = "Cidade:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sans Serif Collection", 8.999999F);
            label13.Location = new Point(96, 263);
            label13.Name = "label13";
            label13.Size = new Size(86, 41);
            label13.TabIndex = 12;
            label13.Text = "Logradouro:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(148, 84);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(270, 23);
            txtnome.TabIndex = 1;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(148, 214);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(188, 23);
            txtemail.TabIndex = 7;
            // 
            // txtlogradouro
            // 
            txtlogradouro.Location = new Point(177, 266);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(241, 23);
            txtlogradouro.TabIndex = 9;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(148, 315);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(270, 23);
            txtbairro.TabIndex = 11;
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(475, 261);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(255, 23);
            txtcidade.TabIndex = 10;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(475, 315);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(255, 23);
            txtestado.TabIndex = 12;
            // 
            // txtdata
            // 
            txtdata.Location = new Point(550, 79);
            txtdata.Mask = "00/00/0000";
            txtdata.Name = "txtdata";
            txtdata.Size = new Size(59, 23);
            txtdata.TabIndex = 2;
            txtdata.Click += txtdata_Click_1;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(485, 121);
            txttelefone.Mask = "(00)0 0000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(79, 23);
            txttelefone.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mulher Cisgênero", "Homem Cisgênero", "Mulher Transgênero", "Homem Transgênero", "Não Binárie", "Gênero Fluido", "Agênero", "Bigênero", "Trigênero", "Gênero Queer", "Gênero Demigênero", "Gênero Andrógeno", "Gênero Andrógino", "Gênero Apagado", "Gênero Clivado", "Gênero Enviado", "Gênero Fugitivo", "Gênero Híbrido", "Gênero Intermediário", "Gênero Livre", "Gênero Místico", "Gênero Padrão", "Gênero Queer Não Binário", "Gênero Radiante", "Gênero Sutil", "Gênero Solar", "Gênero Lunar", "Gênero Transfeminino", "Gênero Transmasculino", "Gênero Elevado", "Gênero Espiritual", "Gênero Específico", "Gênero Livre", "Gênero Metamórfico", "Gênero Mutante", "Gênero Natural", "Gênero Oculto", "Gênero Plural", "Gênero Preciso", "Gênero Profundo", "Gênero Resiliente", "Gênero Sagrado", "Gênero Secundário", "Gênero Superior", "Gênero Transcendente", "Gênero Universal", "Gênero Versátil", "Gênero Virtual", "Gênero Xenogênero", "Gênero Yin", "Gênero Yang", "Gênero Zero" });
            comboBox1.Location = new Point(485, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(461, 214);
            txtcep.Mask = "00.000-000";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(57, 23);
            txtcep.TabIndex = 8;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(130, 126);
            txtcpf.Mask = "000.000.000-00";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(75, 23);
            txtcpf.TabIndex = 3;
            // 
            // txtrg
            // 
            txtrg.Location = new Point(130, 172);
            txtrg.Mask = "00.000.000-0";
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(68, 23);
            txtrg.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(315, 354);
            button1.Name = "button1";
            button1.Size = new Size(191, 71);
            button1.TabIndex = 21;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
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
    }
}