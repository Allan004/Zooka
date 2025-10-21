namespace Zooka
{
    partial class CadastroFornecedor
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

        private void InitializeComponent()
        {
            txtNomeFantasia = new TextBox();
            lblCadastroServicos = new Label();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            lblNomeFantasia = new Label();
            lblCNPJ = new Label();
            txtRazaoSocial = new TextBox();
            lblRazaoSocial = new Label();
            txtCNPJ = new TextBox();
            textBox1 = new TextBox();
            lblCep = new Label();
            txtRua = new TextBox();
            lblRua = new Label();
            textBox2 = new TextBox();
            lblNumero = new Label();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            lblStatus = new Label();
            lblSegmento = new Label();
            radioAtivo = new RadioButton();
            radioInativo = new RadioButton();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.BorderStyle = BorderStyle.None;
            txtNomeFantasia.Font = new Font("Segoe UI", 13F);
            txtNomeFantasia.Location = new Point(95, 192);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(265, 24);
            txtNomeFantasia.TabIndex = 1;
            // 
            // lblCadastroServicos
            // 
            lblCadastroServicos.AutoSize = true;
            lblCadastroServicos.BackColor = Color.Transparent;
            lblCadastroServicos.Font = new Font("Arial Rounded MT Bold", 15F);
            lblCadastroServicos.ForeColor = Color.FromArgb(215, 122, 40);
            lblCadastroServicos.Location = new Point(236, 42);
            lblCadastroServicos.Name = "lblCadastroServicos";
            lblCadastroServicos.Size = new Size(298, 23);
            lblCadastroServicos.TabIndex = 22;
            lblCadastroServicos.Text = "CADASTRO FORNECEDORES";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(169, 213, 186);
            btnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(279, 635);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(188, 62);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.BackColor = Color.Transparent;
            lblNomeFantasia.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblNomeFantasia.ForeColor = Color.FromArgb(215, 122, 40);
            lblNomeFantasia.Location = new Point(95, 166);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(123, 23);
            lblNomeFantasia.TabIndex = 23;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.BackColor = Color.Transparent;
            lblCNPJ.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCNPJ.ForeColor = Color.FromArgb(215, 122, 40);
            lblCNPJ.Location = new Point(95, 247);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(51, 23);
            lblCNPJ.TabIndex = 23;
            lblCNPJ.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BorderStyle = BorderStyle.None;
            txtRazaoSocial.Font = new Font("Segoe UI", 13F);
            txtRazaoSocial.Location = new Point(386, 192);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(265, 24);
            txtRazaoSocial.TabIndex = 1;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.BackColor = Color.Transparent;
            lblRazaoSocial.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblRazaoSocial.ForeColor = Color.FromArgb(215, 122, 40);
            lblRazaoSocial.Location = new Point(386, 166);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(107, 23);
            lblRazaoSocial.TabIndex = 23;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txtCNPJ
            // 
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Font = new Font("Segoe UI", 13F);
            txtCNPJ.Location = new Point(95, 273);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(150, 24);
            txtCNPJ.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(95, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 24);
            textBox1.TabIndex = 8;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCep.ForeColor = Color.FromArgb(215, 122, 40);
            lblCep.Location = new Point(95, 373);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(40, 23);
            lblCep.TabIndex = 23;
            lblCep.Text = "Cep";
            // 
            // txtRua
            // 
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Segoe UI", 13F);
            txtRua.Location = new Point(299, 399);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(150, 24);
            txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.BackColor = Color.Transparent;
            lblRua.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblRua.ForeColor = Color.FromArgb(215, 122, 40);
            lblRua.Location = new Point(299, 373);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(40, 23);
            lblRua.TabIndex = 23;
            lblRua.Text = "Rua";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(501, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 24);
            textBox2.TabIndex = 8;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblNumero.ForeColor = Color.FromArgb(215, 122, 40);
            lblNumero.Location = new Point(501, 373);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(27, 23);
            lblNumero.TabIndex = 23;
            lblNumero.Text = "Nº";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.None;
            txtBairro.Font = new Font("Segoe UI", 13F);
            txtBairro.Location = new Point(95, 468);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(150, 24);
            txtBairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Segoe UI", 13F);
            txtCidade.Location = new Point(299, 468);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(150, 24);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Segoe UI", 13F);
            txtEstado.Location = new Point(501, 468);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(150, 24);
            txtEstado.TabIndex = 8;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblBairro.ForeColor = Color.FromArgb(215, 122, 40);
            lblBairro.Location = new Point(95, 442);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(56, 23);
            lblBairro.TabIndex = 23;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCidade.ForeColor = Color.FromArgb(215, 122, 40);
            lblCidade.Location = new Point(299, 442);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(63, 23);
            lblCidade.TabIndex = 23;
            lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(215, 122, 40);
            lblEstado.Location = new Point(501, 442);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(31, 23);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.None;
            txtComplemento.Font = new Font("Segoe UI", 13F);
            txtComplemento.Location = new Point(95, 555);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(150, 24);
            txtComplemento.TabIndex = 8;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblComplemento.ForeColor = Color.FromArgb(215, 122, 40);
            lblComplemento.Location = new Point(95, 529);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(116, 23);
            lblComplemento.TabIndex = 23;
            lblComplemento.Text = "Complemento";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(215, 122, 40);
            lblStatus.Location = new Point(501, 529);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(58, 23);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "Status";
            // 
            // lblSegmento
            // 
            lblSegmento.AutoSize = true;
            lblSegmento.BackColor = Color.Transparent;
            lblSegmento.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblSegmento.ForeColor = Color.FromArgb(215, 122, 40);
            lblSegmento.Location = new Point(299, 529);
            lblSegmento.Name = "lblSegmento";
            lblSegmento.Size = new Size(87, 23);
            lblSegmento.TabIndex = 23;
            lblSegmento.Text = "Segmento";
            // 
            // radioAtivo
            // 
            radioAtivo.AutoSize = true;
            radioAtivo.Location = new Point(501, 560);
            radioAtivo.Name = "radioAtivo";
            radioAtivo.Size = new Size(53, 19);
            radioAtivo.TabIndex = 56;
            radioAtivo.TabStop = true;
            radioAtivo.Text = "Ativo";
            radioAtivo.UseVisualStyleBackColor = true;
            // 
            // radioInativo
            // 
            radioInativo.AutoSize = true;
            radioInativo.Location = new Point(576, 560);
            radioInativo.Name = "radioInativo";
            radioInativo.Size = new Size(61, 19);
            radioInativo.TabIndex = 56;
            radioInativo.TabStop = true;
            radioInativo.Text = "Inativo";
            radioInativo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 555);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 57;
            // 
            // CadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(747, 756);
            Controls.Add(comboBox1);
            Controls.Add(radioInativo);
            Controls.Add(radioAtivo);
            Controls.Add(btnSalvar);
            Controls.Add(lblSegmento);
            Controls.Add(lblEstado);
            Controls.Add(lblNumero);
            Controls.Add(lblStatus);
            Controls.Add(lblCidade);
            Controls.Add(lblRua);
            Controls.Add(lblComplemento);
            Controls.Add(lblBairro);
            Controls.Add(lblCep);
            Controls.Add(lblCNPJ);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblNomeFantasia);
            Controls.Add(pictureBox1);
            Controls.Add(txtEstado);
            Controls.Add(textBox2);
            Controls.Add(txtCidade);
            Controls.Add(txtComplemento);
            Controls.Add(txtBairro);
            Controls.Add(txtRua);
            Controls.Add(textBox1);
            Controls.Add(txtCNPJ);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtNomeFantasia);
            Controls.Add(lblCadastroServicos);
            Name = "CadastroFornecedor";
            Text = "Servico";
            Load += CadastroFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtNomeFantasia;
        private Label lblCadastroServicos;
        private PictureBox pictureBox1;
        private Button btnSalvar;
        private Label lblNomeFantasia;
        private ComboBox cmbCategoria;
        private Label lblCNPJ;
        private RichTextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtRazaoSocial;
        private Label lblRazaoSocial;
        private TextBox txtCNPJ;
        private TextBox textBox1;
        private Label lblCep;
        private TextBox txtRua;
        private Label lblRua;
        private TextBox textBox2;
        private Label lblNumero;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblEstado;
        private TextBox txtComplemento;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblComplemento;
        private Label lblStatus;
        private Label lblSegmento;
        private RadioButton radioAtivo;
        private RadioButton radioInativo;
        private ComboBox comboBox1;
    }
}
