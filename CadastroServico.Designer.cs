namespace Zooka
{
    partial class CadastroServico
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


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            lblCadastroServicos = new Label();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            lblPreco = new Label();
            lblNome = new Label();
            txtPreco = new TextBox();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtDescricao = new RichTextBox();
            lblDescricao = new Label();
            txtTempo = new TextBox();
            lblTempo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 13F);
            txtNome.Location = new Point(89, 174);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(575, 24);
            txtNome.TabIndex = 1;
            // 
            // lblCadastroServicos
            // 
            lblCadastroServicos.AutoSize = true;
            lblCadastroServicos.BackColor = Color.Transparent;
            lblCadastroServicos.Font = new Font("Arial Rounded MT Bold", 20F);
            lblCadastroServicos.ForeColor = Color.FromArgb(215, 122, 40);
            lblCadastroServicos.Location = new Point(210, 35);
            lblCadastroServicos.Name = "lblCadastroServicos";
            lblCadastroServicos.Size = new Size(315, 32);
            lblCadastroServicos.TabIndex = 22;
            lblCadastroServicos.Text = "CADASTRO SERVIÇOS";
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
            btnSalvar.Location = new Point(285, 479);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(188, 62);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblPreco.ForeColor = Color.FromArgb(215, 122, 40);
            lblPreco.Location = new Point(308, 226);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(88, 23);
            lblPreco.TabIndex = 31;
            lblPreco.Text = "Preço (R$)";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(215, 122, 40);
            lblNome.Location = new Point(89, 148);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(54, 23);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome";
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Font = new Font("Segoe UI", 13F);
            txtPreco.Location = new Point(310, 252);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(150, 24);
            txtPreco.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Vacina", "Corte" });
            cmbCategoria.Location = new Point(89, 255);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(165, 23);
            cmbCategoria.TabIndex = 57;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(215, 122, 40);
            lblCategoria.Location = new Point(89, 229);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(83, 23);
            lblCategoria.TabIndex = 23;
            lblCategoria.Text = "Categoria";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(182, 354);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(384, 96);
            txtDescricao.TabIndex = 58;
            txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblDescricao.ForeColor = Color.FromArgb(215, 122, 40);
            lblDescricao.Location = new Point(339, 328);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(86, 23);
            lblDescricao.TabIndex = 23;
            lblDescricao.Text = "Descrição";
            // 
            // txtTempo
            // 
            txtTempo.BorderStyle = BorderStyle.None;
            txtTempo.Font = new Font("Segoe UI", 13F);
            txtTempo.Location = new Point(512, 252);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(152, 24);
            txtTempo.TabIndex = 1;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblTempo.ForeColor = Color.FromArgb(215, 122, 40);
            lblTempo.Location = new Point(512, 226);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(63, 23);
            lblTempo.TabIndex = 23;
            lblTempo.Text = "Tempo";
            // 
            // Servico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(747, 580);
            Controls.Add(txtDescricao);
            Controls.Add(cmbCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblTempo);
            Controls.Add(lblNome);
            Controls.Add(pictureBox1);
            Controls.Add(txtPreco);
            Controls.Add(txtTempo);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(lblCadastroServicos);
            Name = "Servico";
            Text = "Servico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label lblCadastroServicos;
        private PictureBox pictureBox1;
        private Button btnSalvar;
        private Label lblPreco;
        private Label lblNome;
        private TextBox txtPreco;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private RichTextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtTempo;
        private Label lblTempo;
    }
}
