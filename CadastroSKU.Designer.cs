namespace Zooka
{
    partial class CadastroSKU
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
            Button btnSKU_cancelar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSKU));
            lblSKU_id = new Label();
            txtSKU_id = new TextBox();
            txtSKU_descricao = new TextBox();
            lblSKU_descricao = new Label();
            lblSKU_udm = new Label();
            lblSKU_estoque = new Label();
            btnSKU_criar = new Button();
            cbSKU_estoque = new ComboBox();
            cbSKU_udm = new ComboBox();
            btnSKU_search = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSKU_cancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSKU_cancelar
            // 
            btnSKU_cancelar.BackColor = Color.Transparent;
            btnSKU_cancelar.BackgroundImage = (Image)resources.GetObject("btnSKU_cancelar.BackgroundImage");
            btnSKU_cancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSKU_cancelar.FlatStyle = FlatStyle.Flat;
            btnSKU_cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSKU_cancelar.ForeColor = Color.Transparent;
            btnSKU_cancelar.Location = new Point(410, 327);
            btnSKU_cancelar.Name = "btnSKU_cancelar";
            btnSKU_cancelar.Size = new Size(110, 34);
            btnSKU_cancelar.TabIndex = 11;
            btnSKU_cancelar.Text = "CANCELAR";
            btnSKU_cancelar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_cancelar.UseCompatibleTextRendering = true;
            btnSKU_cancelar.UseVisualStyleBackColor = false;
            btnSKU_cancelar.Click += btnSKU_cancelar_Click;
            // 
            // lblSKU_id
            // 
            lblSKU_id.BackColor = Color.Transparent;
            lblSKU_id.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_id.ForeColor = Color.FromArgb(34, 61, 79);
            lblSKU_id.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_id.Location = new Point(83, 120);
            lblSKU_id.Name = "lblSKU_id";
            lblSKU_id.Size = new Size(53, 25);
            lblSKU_id.TabIndex = 0;
            lblSKU_id.Text = "SKU";
            lblSKU_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSKU_id
            // 
            txtSKU_id.BackColor = Color.AliceBlue;
            txtSKU_id.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU_id.ForeColor = Color.MidnightBlue;
            txtSKU_id.Location = new Point(83, 148);
            txtSKU_id.Multiline = true;
            txtSKU_id.Name = "txtSKU_id";
            txtSKU_id.Size = new Size(93, 23);
            txtSKU_id.TabIndex = 1;
            txtSKU_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSKU_descricao
            // 
            txtSKU_descricao.BackColor = Color.AliceBlue;
            txtSKU_descricao.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU_descricao.ForeColor = Color.MidnightBlue;
            txtSKU_descricao.Location = new Point(208, 148);
            txtSKU_descricao.Multiline = true;
            txtSKU_descricao.Name = "txtSKU_descricao";
            txtSKU_descricao.Size = new Size(312, 23);
            txtSKU_descricao.TabIndex = 3;
            txtSKU_descricao.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSKU_descricao
            // 
            lblSKU_descricao.BackColor = Color.Transparent;
            lblSKU_descricao.Font = new Font("Arial Rounded MT Bold", 20F);
            lblSKU_descricao.ForeColor = Color.White;
            lblSKU_descricao.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_descricao.Location = new Point(197, 30);
            lblSKU_descricao.Name = "lblSKU_descricao";
            lblSKU_descricao.Size = new Size(236, 38);
            lblSKU_descricao.TabIndex = 2;
            lblSKU_descricao.Text = "Cadastro SKU";
            lblSKU_descricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSKU_udm
            // 
            lblSKU_udm.BackColor = Color.Transparent;
            lblSKU_udm.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_udm.ForeColor = Color.FromArgb(34, 61, 79);
            lblSKU_udm.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_udm.Location = new Point(83, 195);
            lblSKU_udm.Name = "lblSKU_udm";
            lblSKU_udm.Size = new Size(53, 25);
            lblSKU_udm.TabIndex = 4;
            lblSKU_udm.Text = "UDM";
            lblSKU_udm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSKU_estoque
            // 
            lblSKU_estoque.BackColor = Color.Transparent;
            lblSKU_estoque.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_estoque.ForeColor = Color.FromArgb(34, 61, 79);
            lblSKU_estoque.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_estoque.Location = new Point(208, 195);
            lblSKU_estoque.Name = "lblSKU_estoque";
            lblSKU_estoque.Size = new Size(93, 25);
            lblSKU_estoque.TabIndex = 6;
            lblSKU_estoque.Text = "ESTOQUE";
            lblSKU_estoque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSKU_criar
            // 
            btnSKU_criar.BackColor = Color.Transparent;
            btnSKU_criar.BackgroundImage = (Image)resources.GetObject("btnSKU_criar.BackgroundImage");
            btnSKU_criar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSKU_criar.FlatStyle = FlatStyle.Flat;
            btnSKU_criar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSKU_criar.ForeColor = Color.Transparent;
            btnSKU_criar.Location = new Point(294, 327);
            btnSKU_criar.Name = "btnSKU_criar";
            btnSKU_criar.Size = new Size(110, 34);
            btnSKU_criar.TabIndex = 8;
            btnSKU_criar.Text = "OK";
            btnSKU_criar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_criar.UseCompatibleTextRendering = true;
            btnSKU_criar.UseVisualStyleBackColor = false;
            btnSKU_criar.Click += btnSKU_criar_Click;
            // 
            // cbSKU_estoque
            // 
            cbSKU_estoque.BackColor = Color.AliceBlue;
            cbSKU_estoque.FlatStyle = FlatStyle.Flat;
            cbSKU_estoque.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSKU_estoque.FormattingEnabled = true;
            cbSKU_estoque.Location = new Point(208, 223);
            cbSKU_estoque.Name = "cbSKU_estoque";
            cbSKU_estoque.Size = new Size(93, 23);
            cbSKU_estoque.TabIndex = 9;
            // 
            // cbSKU_udm
            // 
            cbSKU_udm.BackColor = Color.AliceBlue;
            cbSKU_udm.FlatStyle = FlatStyle.Flat;
            cbSKU_udm.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSKU_udm.FormattingEnabled = true;
            cbSKU_udm.Location = new Point(83, 223);
            cbSKU_udm.Name = "cbSKU_udm";
            cbSKU_udm.Size = new Size(93, 23);
            cbSKU_udm.TabIndex = 10;
            // 
            // btnSKU_search
            // 
            btnSKU_search.BackColor = Color.AliceBlue;
            btnSKU_search.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_search.ForeColor = Color.MidnightBlue;
            btnSKU_search.Image = (Image)resources.GetObject("btnSKU_search.Image");
            btnSKU_search.Location = new Point(37, 143);
            btnSKU_search.Name = "btnSKU_search";
            btnSKU_search.Size = new Size(34, 32);
            btnSKU_search.TabIndex = 12;
            btnSKU_search.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSKU_search.UseCompatibleTextRendering = true;
            btnSKU_search.UseVisualStyleBackColor = false;
            btnSKU_search.Click += btnSKU_search_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSKU_descricao);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 94);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // CadastroSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 377);
            Controls.Add(panel1);
            Controls.Add(btnSKU_search);
            Controls.Add(btnSKU_cancelar);
            Controls.Add(cbSKU_udm);
            Controls.Add(cbSKU_estoque);
            Controls.Add(btnSKU_criar);
            Controls.Add(lblSKU_estoque);
            Controls.Add(lblSKU_udm);
            Controls.Add(txtSKU_descricao);
            Controls.Add(txtSKU_id);
            Controls.Add(lblSKU_id);
            DoubleBuffered = true;
            Name = "CadastroSKU";
            Text = "Cadastro de SKU";
            Load += CadastroSKU_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSKU_id;
        private TextBox txtSKU_id;
        private TextBox txtSKU_descricao;
        private Label lblSKU_descricao;
        private Label lblSKU_udm;
        private Label lblSKU_estoque;
        private Button btnSKU_criar;
        private ComboBox cbSKU_estoque;
        private ComboBox cbSKU_udm;
        private Button btnSKU_cancelar;
        private Button btnSKU_search;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}