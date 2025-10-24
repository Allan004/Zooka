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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroServico));
            txtNome = new TextBox();
            lblCadastroServicos = new Label();
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.AliceBlue;
            txtNome.Font = new Font("Arial", 12F);
            txtNome.Location = new Point(174, 174);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(355, 26);
            txtNome.TabIndex = 1;
            // 
            // lblCadastroServicos
            // 
            lblCadastroServicos.AutoSize = true;
            lblCadastroServicos.BackColor = Color.FromArgb(34, 61, 79);
            lblCadastroServicos.Font = new Font("Arial Rounded MT Bold", 20F);
            lblCadastroServicos.ForeColor = Color.White;
            lblCadastroServicos.Location = new Point(180, 33);
            lblCadastroServicos.Name = "lblCadastroServicos";
            lblCadastroServicos.Size = new Size(243, 32);
            lblCadastroServicos.TabIndex = 22;
            lblCadastroServicos.Text = "Cadastro Serviço";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BackgroundImage = (Image)resources.GetObject("btnSalvar.BackgroundImage");
            btnSalvar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(419, 491);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 34);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Gadugi", 12F);
            lblPreco.ForeColor = Color.FromArgb(34, 61, 79);
            lblPreco.Location = new Point(207, 229);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(81, 19);
            lblPreco.TabIndex = 31;
            lblPreco.Text = "Preço (R$)";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Gadugi", 12F);
            lblNome.ForeColor = Color.FromArgb(34, 61, 79);
            lblNome.Location = new Point(174, 148);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 19);
            lblNome.TabIndex = 23;
            lblNome.Text = "Nome";
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.AliceBlue;
            txtPreco.Font = new Font("Arial", 12F);
            txtPreco.Location = new Point(207, 255);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(152, 26);
            txtPreco.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.AliceBlue;
            cmbCategoria.Font = new Font("Arial", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Vacina", "Corte" });
            cmbCategoria.Location = new Point(37, 255);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(152, 26);
            cmbCategoria.TabIndex = 57;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Gadugi", 12F);
            lblCategoria.ForeColor = Color.FromArgb(34, 61, 79);
            lblCategoria.Location = new Point(37, 229);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(76, 19);
            lblCategoria.TabIndex = 23;
            lblCategoria.Text = "Categoria";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.AliceBlue;
            txtDescricao.Font = new Font("Arial", 12F);
            txtDescricao.Location = new Point(37, 354);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(492, 96);
            txtDescricao.TabIndex = 58;
            txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Gadugi", 12F);
            lblDescricao.ForeColor = Color.FromArgb(34, 61, 79);
            lblDescricao.Location = new Point(37, 332);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(76, 19);
            lblDescricao.TabIndex = 23;
            lblDescricao.Text = "Descrição";
            // 
            // txtTempo
            // 
            txtTempo.BackColor = Color.AliceBlue;
            txtTempo.Font = new Font("Arial", 12F);
            txtTempo.Location = new Point(377, 255);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(152, 26);
            txtTempo.TabIndex = 1;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.Transparent;
            lblTempo.Font = new Font("Gadugi", 12F);
            lblTempo.ForeColor = Color.FromArgb(34, 61, 79);
            lblTempo.Location = new Point(377, 229);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(57, 19);
            lblTempo.TabIndex = 23;
            lblTempo.Text = "Tempo";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.AliceBlue;
            txtCodigo.Font = new Font("Arial", 12F);
            txtCodigo.Location = new Point(37, 174);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(108, 26);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Gadugi", 12F);
            lblCodigo.ForeColor = Color.FromArgb(34, 61, 79);
            lblCodigo.Location = new Point(37, 148);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(59, 19);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblCadastroServicos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 94);
            panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(563, 537);
            Controls.Add(txtDescricao);
            Controls.Add(cmbCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblTempo);
            Controls.Add(lblCodigo);
            Controls.Add(lblNome);
            Controls.Add(txtPreco);
            Controls.Add(txtTempo);
            Controls.Add(txtCodigo);
            Controls.Add(txtNome);
            Controls.Add(lblPreco);
            Controls.Add(panel1);
            Name = "CadastroServico";
            Text = "Servico";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private Label lblCadastroServicos;
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
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
