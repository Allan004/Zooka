namespace Zooka
{
    partial class ordem_de_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordem_de_compra));
            lblFornecedor = new Label();
            txtFornecedor_oc = new TextBox();
            lblComprador = new Label();
            txtComprador = new TextBox();
            lblNumeroOC = new Label();
            dgvItensOC = new DataGridView();
            txtNumeroOC = new TextBox();
            txtDataOC = new TextBox();
            lblData = new Label();
            lblTotalOC = new TextBox();
            btnSalvarOC = new Button();
            lblTotal = new Label();
            txtFreteOC = new TextBox();
            lblPagamento = new Label();
            cbPagamentoOC = new ComboBox();
            btnCriarSKU_OC = new Button();
            txtFornecedorCNPJ_OC = new TextBox();
            lblFrete = new Label();
            label1 = new Label();
            txtRazaoSocialZooka_OC = new TextBox();
            txtCNPJZooka_OC = new TextBox();
            txtNomeFantasiaZooka_OC = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItensOC).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFornecedor.ForeColor = Color.FromArgb(34, 61, 79);
            lblFornecedor.Location = new Point(24, 380);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(114, 19);
            lblFornecedor.TabIndex = 0;
            lblFornecedor.Text = "FORNECEDOR";
            // 
            // txtFornecedor_oc
            // 
            txtFornecedor_oc.BackColor = Color.AliceBlue;
            txtFornecedor_oc.Font = new Font("Arial", 12F);
            txtFornecedor_oc.Location = new Point(24, 402);
            txtFornecedor_oc.Name = "txtFornecedor_oc";
            txtFornecedor_oc.Size = new Size(365, 26);
            txtFornecedor_oc.TabIndex = 1;
            // 
            // lblComprador
            // 
            lblComprador.AutoSize = true;
            lblComprador.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComprador.ForeColor = Color.FromArgb(34, 61, 79);
            lblComprador.Location = new Point(24, 316);
            lblComprador.Name = "lblComprador";
            lblComprador.Size = new Size(111, 19);
            lblComprador.TabIndex = 2;
            lblComprador.Text = "COMPRADOR";
            // 
            // txtComprador
            // 
            txtComprador.BackColor = Color.AliceBlue;
            txtComprador.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtComprador.Location = new Point(24, 338);
            txtComprador.Name = "txtComprador";
            txtComprador.Size = new Size(365, 26);
            txtComprador.TabIndex = 3;
            // 
            // lblNumeroOC
            // 
            lblNumeroOC.AutoSize = true;
            lblNumeroOC.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroOC.ForeColor = Color.FromArgb(34, 61, 79);
            lblNumeroOC.Location = new Point(24, 263);
            lblNumeroOC.Name = "lblNumeroOC";
            lblNumeroOC.Size = new Size(55, 19);
            lblNumeroOC.TabIndex = 4;
            lblNumeroOC.Text = "Nº OC";
            // 
            // dgvItensOC
            // 
            dgvItensOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensOC.Location = new Point(441, 126);
            dgvItensOC.Name = "dgvItensOC";
            dgvItensOC.Size = new Size(722, 530);
            dgvItensOC.TabIndex = 6;
            // 
            // txtNumeroOC
            // 
            txtNumeroOC.BackColor = Color.AliceBlue;
            txtNumeroOC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumeroOC.ForeColor = Color.Black;
            txtNumeroOC.Location = new Point(24, 281);
            txtNumeroOC.Multiline = true;
            txtNumeroOC.Name = "txtNumeroOC";
            txtNumeroOC.Size = new Size(105, 23);
            txtNumeroOC.TabIndex = 7;
            txtNumeroOC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDataOC
            // 
            txtDataOC.BackColor = Color.AliceBlue;
            txtDataOC.Font = new Font("Arial", 12F);
            txtDataOC.Location = new Point(284, 281);
            txtDataOC.Name = "txtDataOC";
            txtDataOC.Size = new Size(105, 26);
            txtDataOC.TabIndex = 9;
            txtDataOC.TextAlign = HorizontalAlignment.Center;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.FromArgb(34, 61, 79);
            lblData.Location = new Point(284, 263);
            lblData.Name = "lblData";
            lblData.Size = new Size(52, 19);
            lblData.TabIndex = 8;
            lblData.Text = "DATA";
            // 
            // lblTotalOC
            // 
            lblTotalOC.BackColor = Color.AliceBlue;
            lblTotalOC.Font = new Font("Arial", 12F);
            lblTotalOC.Location = new Point(24, 599);
            lblTotalOC.Name = "lblTotalOC";
            lblTotalOC.Size = new Size(105, 26);
            lblTotalOC.TabIndex = 10;
            // 
            // btnSalvarOC
            // 
            btnSalvarOC.BackColor = Color.Transparent;
            btnSalvarOC.BackgroundImage = (Image)resources.GetObject("btnSalvarOC.BackgroundImage");
            btnSalvarOC.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalvarOC.FlatStyle = FlatStyle.Flat;
            btnSalvarOC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarOC.ForeColor = Color.White;
            btnSalvarOC.Location = new Point(937, 673);
            btnSalvarOC.Name = "btnSalvarOC";
            btnSalvarOC.Size = new Size(110, 34);
            btnSalvarOC.TabIndex = 11;
            btnSalvarOC.Text = "SALVAR OC";
            btnSalvarOC.UseVisualStyleBackColor = false;
            btnSalvarOC.Click += btnSalvarOC_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(34, 61, 79);
            lblTotal.Location = new Point(24, 577);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 19);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // txtFreteOC
            // 
            txtFreteOC.BackColor = Color.AliceBlue;
            txtFreteOC.Font = new Font("Arial", 12F);
            txtFreteOC.Location = new Point(24, 535);
            txtFreteOC.Name = "txtFreteOC";
            txtFreteOC.Size = new Size(105, 26);
            txtFreteOC.TabIndex = 13;
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamento.ForeColor = Color.FromArgb(34, 61, 79);
            lblPagamento.Location = new Point(248, 513);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(110, 19);
            lblPagamento.TabIndex = 16;
            lblPagamento.Text = "PAGAMENTO";
            // 
            // cbPagamentoOC
            // 
            cbPagamentoOC.BackColor = Color.AliceBlue;
            cbPagamentoOC.FlatStyle = FlatStyle.Flat;
            cbPagamentoOC.Font = new Font("Arial", 12F);
            cbPagamentoOC.FormattingEnabled = true;
            cbPagamentoOC.Location = new Point(248, 535);
            cbPagamentoOC.Name = "cbPagamentoOC";
            cbPagamentoOC.Size = new Size(141, 26);
            cbPagamentoOC.TabIndex = 17;
            // 
            // btnCriarSKU_OC
            // 
            btnCriarSKU_OC.BackColor = Color.Transparent;
            btnCriarSKU_OC.BackgroundImage = (Image)resources.GetObject("btnCriarSKU_OC.BackgroundImage");
            btnCriarSKU_OC.BackgroundImageLayout = ImageLayout.Stretch;
            btnCriarSKU_OC.FlatStyle = FlatStyle.Flat;
            btnCriarSKU_OC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCriarSKU_OC.ForeColor = Color.White;
            btnCriarSKU_OC.Location = new Point(1053, 673);
            btnCriarSKU_OC.Name = "btnCriarSKU_OC";
            btnCriarSKU_OC.Size = new Size(110, 34);
            btnCriarSKU_OC.TabIndex = 18;
            btnCriarSKU_OC.Text = "CRIAR SKU";
            btnCriarSKU_OC.UseVisualStyleBackColor = false;
            btnCriarSKU_OC.Click += btnCriarSKU_OC_Click;
            // 
            // txtFornecedorCNPJ_OC
            // 
            txtFornecedorCNPJ_OC.BackColor = Color.AliceBlue;
            txtFornecedorCNPJ_OC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFornecedorCNPJ_OC.Location = new Point(24, 467);
            txtFornecedorCNPJ_OC.Name = "txtFornecedorCNPJ_OC";
            txtFornecedorCNPJ_OC.Size = new Size(167, 26);
            txtFornecedorCNPJ_OC.TabIndex = 19;
            // 
            // lblFrete
            // 
            lblFrete.AutoSize = true;
            lblFrete.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrete.ForeColor = Color.FromArgb(34, 61, 79);
            lblFrete.Location = new Point(24, 513);
            lblFrete.Name = "lblFrete";
            lblFrete.Size = new Size(54, 19);
            lblFrete.TabIndex = 14;
            lblFrete.Text = "FRETE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(34, 61, 79);
            label1.Location = new Point(24, 445);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 20;
            label1.Text = "CNPJ FORNECEDOR";
            // 
            // txtRazaoSocialZooka_OC
            // 
            txtRazaoSocialZooka_OC.BackColor = Color.AliceBlue;
            txtRazaoSocialZooka_OC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRazaoSocialZooka_OC.Location = new Point(24, 155);
            txtRazaoSocialZooka_OC.Name = "txtRazaoSocialZooka_OC";
            txtRazaoSocialZooka_OC.Size = new Size(365, 26);
            txtRazaoSocialZooka_OC.TabIndex = 22;
            // 
            // txtCNPJZooka_OC
            // 
            txtCNPJZooka_OC.BackColor = Color.AliceBlue;
            txtCNPJZooka_OC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCNPJZooka_OC.Location = new Point(24, 184);
            txtCNPJZooka_OC.Name = "txtCNPJZooka_OC";
            txtCNPJZooka_OC.Size = new Size(176, 26);
            txtCNPJZooka_OC.TabIndex = 23;
            // 
            // txtNomeFantasiaZooka_OC
            // 
            txtNomeFantasiaZooka_OC.BackColor = Color.AliceBlue;
            txtNomeFantasiaZooka_OC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNomeFantasiaZooka_OC.Location = new Point(24, 126);
            txtNomeFantasiaZooka_OC.Name = "txtNomeFantasiaZooka_OC";
            txtNomeFantasiaZooka_OC.Size = new Size(105, 26);
            txtNomeFantasiaZooka_OC.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 94);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(483, 33);
            label2.Name = "label2";
            label2.Size = new Size(256, 32);
            label2.TabIndex = 0;
            label2.Text = "Ordem de Compra";
            // 
            // ordem_de_compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 728);
            Controls.Add(panel1);
            Controls.Add(txtNomeFantasiaZooka_OC);
            Controls.Add(txtCNPJZooka_OC);
            Controls.Add(txtRazaoSocialZooka_OC);
            Controls.Add(label1);
            Controls.Add(txtFornecedorCNPJ_OC);
            Controls.Add(btnCriarSKU_OC);
            Controls.Add(cbPagamentoOC);
            Controls.Add(txtFreteOC);
            Controls.Add(btnSalvarOC);
            Controls.Add(lblTotalOC);
            Controls.Add(txtDataOC);
            Controls.Add(txtNumeroOC);
            Controls.Add(dgvItensOC);
            Controls.Add(txtComprador);
            Controls.Add(txtFornecedor_oc);
            Controls.Add(lblPagamento);
            Controls.Add(lblFrete);
            Controls.Add(lblTotal);
            Controls.Add(lblData);
            Controls.Add(lblNumeroOC);
            Controls.Add(lblComprador);
            Controls.Add(lblFornecedor);
            Name = "ordem_de_compra";
            Text = "Ordem De Compras";
            Load += ordem_de_compra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensOC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFornecedor;
        private TextBox txtFornecedor_oc;
        private Label lblComprador;
        private TextBox txtComprador;
        private Label lblNumeroOC;
        private DataGridView dgvItensOC;
        private TextBox txtNumeroOC;
        private TextBox txtDataOC;
        private Label lblData;
        private TextBox lblTotalOC;
        private Button btnSalvarOC;
        private Label lblTotal;
        private TextBox txtFreteOC;
        private Label lblPagamento;
        private ComboBox cbPagamentoOC;
        private Button btnCriarSKU_OC;
        private TextBox txtFornecedorCNPJ_OC;
        private Label lblFrete;
        private Label label1;
        private TextBox txtRazaoSocialZooka_OC;
        private TextBox txtCNPJZooka_OC;
        private TextBox txtNomeFantasiaZooka_OC;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}