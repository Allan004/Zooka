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
            txtCep = new TextBox();
            lblCep = new Label();
            txtRua = new TextBox();
            lblRua = new Label();
            txtNumeroEndereco = new TextBox();
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
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            cmbSegmento = new ComboBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtTelefoneRepresentante = new TextBox();
            lblContato = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.BorderStyle = BorderStyle.None;
            txtNomeFantasia.Font = new Font("Segoe UI", 13F);
            txtNomeFantasia.Location = new Point(95, 167);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(265, 24);
            txtNomeFantasia.TabIndex = 1;
            // 
            // lblCadastroServicos
            // 
            lblCadastroServicos.AutoSize = true;
            lblCadastroServicos.BackColor = Color.Transparent;
            lblCadastroServicos.Font = new Font("Arial Rounded MT Bold", 20F);
            lblCadastroServicos.ForeColor = Color.FromArgb(215, 122, 40);
            lblCadastroServicos.Location = new Point(185, 27);
            lblCadastroServicos.Name = "lblCadastroServicos";
            lblCadastroServicos.Size = new Size(403, 32);
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
            btnSalvar.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(279, 732);
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
            lblNomeFantasia.Location = new Point(95, 141);
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
            lblCNPJ.Location = new Point(95, 207);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(51, 23);
            lblCNPJ.TabIndex = 23;
            lblCNPJ.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BorderStyle = BorderStyle.None;
            txtRazaoSocial.Font = new Font("Segoe UI", 13F);
            txtRazaoSocial.Location = new Point(386, 167);
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
            lblRazaoSocial.Location = new Point(386, 141);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(107, 23);
            lblRazaoSocial.TabIndex = 23;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txtCNPJ
            // 
            txtCNPJ.BorderStyle = BorderStyle.None;
            txtCNPJ.Font = new Font("Segoe UI", 13F);
            txtCNPJ.Location = new Point(95, 233);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(166, 24);
            txtCNPJ.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.None;
            txtCep.Font = new Font("Segoe UI", 13F);
            txtCep.Location = new Point(95, 438);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(166, 24);
            txtCep.TabIndex = 8;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCep.ForeColor = Color.FromArgb(215, 122, 40);
            lblCep.Location = new Point(95, 412);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(40, 23);
            lblCep.TabIndex = 23;
            lblCep.Text = "Cep";
            // 
            // txtRua
            // 
            txtRua.BorderStyle = BorderStyle.None;
            txtRua.Font = new Font("Segoe UI", 13F);
            txtRua.Location = new Point(95, 502);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(390, 24);
            txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.BackColor = Color.Transparent;
            lblRua.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblRua.ForeColor = Color.FromArgb(215, 122, 40);
            lblRua.Location = new Point(95, 476);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(40, 23);
            lblRua.TabIndex = 23;
            lblRua.Text = "Rua";
            // 
            // txtNumeroEndereco
            // 
            txtNumeroEndereco.BorderStyle = BorderStyle.None;
            txtNumeroEndereco.Font = new Font("Segoe UI", 13F);
            txtNumeroEndereco.Location = new Point(501, 502);
            txtNumeroEndereco.Name = "txtNumeroEndereco";
            txtNumeroEndereco.Size = new Size(150, 24);
            txtNumeroEndereco.TabIndex = 8;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblNumero.ForeColor = Color.FromArgb(215, 122, 40);
            lblNumero.Location = new Point(501, 476);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(27, 23);
            lblNumero.TabIndex = 23;
            lblNumero.Text = "Nº";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.None;
            txtBairro.Font = new Font("Segoe UI", 13F);
            txtBairro.Location = new Point(95, 571);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(166, 24);
            txtBairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.None;
            txtCidade.Font = new Font("Segoe UI", 13F);
            txtCidade.Location = new Point(299, 571);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(168, 24);
            txtCidade.TabIndex = 8;
            // 
            // txtEstado
            // 
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.Font = new Font("Segoe UI", 13F);
            txtEstado.Location = new Point(501, 571);
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
            lblBairro.Location = new Point(95, 545);
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
            lblCidade.Location = new Point(299, 545);
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
            lblEstado.Location = new Point(501, 545);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(31, 23);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.None;
            txtComplemento.Font = new Font("Segoe UI", 13F);
            txtComplemento.Location = new Point(95, 633);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(166, 24);
            txtComplemento.TabIndex = 8;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblComplemento.ForeColor = Color.FromArgb(215, 122, 40);
            lblComplemento.Location = new Point(95, 607);
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
            lblStatus.Location = new Point(503, 412);
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
            lblSegmento.Location = new Point(501, 610);
            lblSegmento.Name = "lblSegmento";
            lblSegmento.Size = new Size(87, 23);
            lblSegmento.TabIndex = 23;
            lblSegmento.Text = "Segmento";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(503, 443);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 56;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            rdbAtivo.CheckedChanged += rdbAtivo_CheckedChanged;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(578, 443);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 56;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            rdbInativo.CheckedChanged += rdbInativo_CheckedChanged;
            // 
            // cmbSegmento
            // 
            cmbSegmento.FormattingEnabled = true;
            cmbSegmento.Location = new Point(503, 636);
            cmbSegmento.Name = "cmbSegmento";
            cmbSegmento.Size = new Size(148, 23);
            cmbSegmento.TabIndex = 57;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(95, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 24);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(215, 122, 40);
            lblEmail.Location = new Point(95, 274);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Font = new Font("Segoe UI", 13F);
            txtTelefone.Location = new Point(279, 300);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 24);
            txtTelefone.TabIndex = 8;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(215, 122, 40);
            lblTelefone.Location = new Point(279, 274);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 23);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefoneRepresentante
            // 
            txtTelefoneRepresentante.BorderStyle = BorderStyle.None;
            txtTelefoneRepresentante.Font = new Font("Segoe UI", 13F);
            txtTelefoneRepresentante.Location = new Point(470, 300);
            txtTelefoneRepresentante.Name = "txtTelefoneRepresentante";
            txtTelefoneRepresentante.Size = new Size(191, 24);
            txtTelefoneRepresentante.TabIndex = 8;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.Transparent;
            lblContato.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblContato.ForeColor = Color.FromArgb(215, 122, 40);
            lblContato.Location = new Point(470, 274);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(191, 23);
            lblContato.TabIndex = 23;
            lblContato.Text = "Telefone Representante";
            // 
            // CadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(741, 852);
            Controls.Add(cmbSegmento);
            Controls.Add(rdbInativo);
            Controls.Add(rdbAtivo);
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
            Controls.Add(lblContato);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblCNPJ);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblNomeFantasia);
            Controls.Add(pictureBox1);
            Controls.Add(txtEstado);
            Controls.Add(txtNumeroEndereco);
            Controls.Add(txtCidade);
            Controls.Add(txtComplemento);
            Controls.Add(txtBairro);
            Controls.Add(txtRua);
            Controls.Add(txtCep);
            Controls.Add(txtTelefoneRepresentante);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
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
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtRua;
        private Label lblRua;
        private TextBox txtNumeroEndereco;
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
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private ComboBox cmbSegmento;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtTelefoneRepresentante;
        private Label lblContato;
    }
}
