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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFornecedor));
            txtNomeFantasia = new TextBox();
            lblCadastroServicos = new Label();
            btnSalvar = new Button();
            lblNomeFantasia = new Label();
            lblCNPJ = new Label();
            txtRazaoSocial = new TextBox();
            lblRazaoSocial = new Label();
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
            txtCNPJ = new MaskedTextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.BackColor = Color.AliceBlue;
            txtNomeFantasia.Font = new Font("Arial", 12F);
            txtNomeFantasia.Location = new Point(37, 178);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(265, 26);
            txtNomeFantasia.TabIndex = 1;
            // 
            // lblCadastroServicos
            // 
            lblCadastroServicos.AutoSize = true;
            lblCadastroServicos.BackColor = Color.FromArgb(34, 61, 79);
            lblCadastroServicos.Font = new Font("Arial Rounded MT Bold", 20F);
            lblCadastroServicos.ForeColor = Color.White;
            lblCadastroServicos.Location = new Point(145, 38);
            lblCadastroServicos.Name = "lblCadastroServicos";
            lblCadastroServicos.Size = new Size(403, 32);
            lblCadastroServicos.TabIndex = 22;
            lblCadastroServicos.Text = "CADASTRO FORNECEDORES";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(488, 705);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 34);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.BackColor = Color.Transparent;
            lblNomeFantasia.Font = new Font("Gadugi", 12F);
            lblNomeFantasia.ForeColor = Color.FromArgb(34, 61, 79);
            lblNomeFantasia.Location = new Point(37, 156);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(113, 19);
            lblNomeFantasia.TabIndex = 23;
            lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.BackColor = Color.Transparent;
            lblCNPJ.Font = new Font("Gadugi", 12F);
            lblCNPJ.ForeColor = Color.FromArgb(34, 61, 79);
            lblCNPJ.Location = new Point(37, 231);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(46, 19);
            lblCNPJ.TabIndex = 23;
            lblCNPJ.Text = "CNPJ";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.AliceBlue;
            txtRazaoSocial.Font = new Font("Arial", 12F);
            txtRazaoSocial.Location = new Point(328, 178);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(270, 26);
            txtRazaoSocial.TabIndex = 2;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.BackColor = Color.Transparent;
            lblRazaoSocial.Font = new Font("Gadugi", 12F);
            lblRazaoSocial.ForeColor = Color.FromArgb(34, 61, 79);
            lblRazaoSocial.Location = new Point(328, 156);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(96, 19);
            lblRazaoSocial.TabIndex = 23;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txtCep
            // 
            txtCep.BackColor = Color.AliceBlue;
            txtCep.Font = new Font("Arial", 12F);
            txtCep.Location = new Point(37, 411);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(166, 26);
            txtCep.TabIndex = 7;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Gadugi", 12F);
            lblCep.ForeColor = Color.FromArgb(34, 61, 79);
            lblCep.Location = new Point(37, 384);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(36, 19);
            lblCep.TabIndex = 23;
            lblCep.Text = "Cep";
            // 
            // txtRua
            // 
            txtRua.BackColor = Color.AliceBlue;
            txtRua.Font = new Font("Arial", 12F);
            txtRua.Location = new Point(37, 474);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(390, 26);
            txtRua.TabIndex = 8;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.BackColor = Color.Transparent;
            lblRua.Font = new Font("Gadugi", 12F);
            lblRua.ForeColor = Color.FromArgb(34, 61, 79);
            lblRua.Location = new Point(37, 448);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(36, 19);
            lblRua.TabIndex = 23;
            lblRua.Text = "Rua";
            // 
            // txtNumeroEndereco
            // 
            txtNumeroEndereco.BackColor = Color.AliceBlue;
            txtNumeroEndereco.Font = new Font("Arial", 12F);
            txtNumeroEndereco.Location = new Point(446, 474);
            txtNumeroEndereco.Name = "txtNumeroEndereco";
            txtNumeroEndereco.Size = new Size(152, 26);
            txtNumeroEndereco.TabIndex = 9;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Font = new Font("Gadugi", 12F);
            lblNumero.ForeColor = Color.FromArgb(34, 61, 79);
            lblNumero.Location = new Point(446, 448);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(28, 19);
            lblNumero.TabIndex = 23;
            lblNumero.Text = "Nº";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.AliceBlue;
            txtBairro.Font = new Font("Arial", 12F);
            txtBairro.Location = new Point(37, 543);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(166, 26);
            txtBairro.TabIndex = 10;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = Color.AliceBlue;
            txtCidade.Font = new Font("Arial", 12F);
            txtCidade.Location = new Point(242, 543);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(168, 26);
            txtCidade.TabIndex = 11;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = Color.AliceBlue;
            txtEstado.Font = new Font("Arial", 12F);
            txtEstado.Location = new Point(448, 543);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(150, 26);
            txtEstado.TabIndex = 12;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Font = new Font("Gadugi", 12F);
            lblBairro.ForeColor = Color.FromArgb(34, 61, 79);
            lblBairro.Location = new Point(37, 517);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(51, 19);
            lblBairro.TabIndex = 23;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Gadugi", 12F);
            lblCidade.ForeColor = Color.FromArgb(34, 61, 79);
            lblCidade.Location = new Point(242, 517);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(57, 19);
            lblCidade.TabIndex = 23;
            lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Gadugi", 12F);
            lblEstado.ForeColor = Color.FromArgb(34, 61, 79);
            lblEstado.Location = new Point(448, 521);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(28, 19);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "UF";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = Color.AliceBlue;
            txtComplemento.Font = new Font("Arial", 12F);
            txtComplemento.Location = new Point(37, 608);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(166, 26);
            txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Font = new Font("Gadugi", 12F);
            lblComplemento.ForeColor = Color.FromArgb(34, 61, 79);
            lblComplemento.Location = new Point(37, 582);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(108, 19);
            lblComplemento.TabIndex = 23;
            lblComplemento.Text = "Complemento";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Gadugi", 12F);
            lblStatus.ForeColor = Color.FromArgb(34, 61, 79);
            lblStatus.Location = new Point(448, 384);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 19);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "Status";
            // 
            // lblSegmento
            // 
            lblSegmento.AutoSize = true;
            lblSegmento.BackColor = Color.Transparent;
            lblSegmento.Font = new Font("Gadugi", 12F);
            lblSegmento.ForeColor = Color.FromArgb(34, 61, 79);
            lblSegmento.Location = new Point(446, 582);
            lblSegmento.Name = "lblSegmento";
            lblSegmento.Size = new Size(80, 19);
            lblSegmento.TabIndex = 23;
            lblSegmento.Text = "Segmento";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(448, 415);
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
            rdbInativo.Location = new Point(523, 415);
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
            cmbSegmento.BackColor = Color.AliceBlue;
            cmbSegmento.FlatStyle = FlatStyle.Popup;
            cmbSegmento.Font = new Font("Arial", 12F);
            cmbSegmento.FormattingEnabled = true;
            cmbSegmento.Location = new Point(446, 604);
            cmbSegmento.Name = "cmbSegmento";
            cmbSegmento.Size = new Size(148, 26);
            cmbSegmento.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AliceBlue;
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(37, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 26);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Gadugi", 12F);
            lblEmail.ForeColor = Color.FromArgb(34, 61, 79);
            lblEmail.Location = new Point(37, 303);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 19);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.AliceBlue;
            txtTelefone.Font = new Font("Arial", 12F);
            txtTelefone.Location = new Point(232, 329);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(166, 26);
            txtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Gadugi", 12F);
            lblTelefone.ForeColor = Color.FromArgb(34, 61, 79);
            lblTelefone.Location = new Point(232, 307);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(32, 19);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Tel.";
            // 
            // txtTelefoneRepresentante
            // 
            txtTelefoneRepresentante.BackColor = Color.AliceBlue;
            txtTelefoneRepresentante.Font = new Font("Arial", 12F);
            txtTelefoneRepresentante.Location = new Point(427, 329);
            txtTelefoneRepresentante.Name = "txtTelefoneRepresentante";
            txtTelefoneRepresentante.Size = new Size(171, 26);
            txtTelefoneRepresentante.TabIndex = 6;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.BackColor = Color.Transparent;
            lblContato.Font = new Font("Gadugi", 12F);
            lblContato.ForeColor = Color.FromArgb(34, 61, 79);
            lblContato.Location = new Point(427, 307);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(136, 19);
            lblContato.TabIndex = 23;
            lblContato.Text = "Tel. Representante";
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.AliceBlue;
            txtCNPJ.Font = new Font("Arial", 12F);
            txtCNPJ.Location = new Point(37, 253);
            txtCNPJ.Mask = "00.000.000/0000-00";
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(166, 26);
            txtCNPJ.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 94);
            panel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // CadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 768);
            Controls.Add(txtCNPJ);
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
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtNomeFantasia);
            Controls.Add(lblCadastroServicos);
            Controls.Add(panel1);
            Name = "CadastroFornecedor";
            Text = "Servico";
            Load += CadastroFornecedor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtNomeFantasia;
        private Label lblCadastroServicos;
        private Button btnSalvar;
        private Label lblNomeFantasia;
        private ComboBox cmbCategoria;
        private Label lblCNPJ;
        private RichTextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtRazaoSocial;
        private Label lblRazaoSocial;
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
        private MaskedTextBox txtCNPJ;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
