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
            ((System.ComponentModel.ISupportInitialize)dgvItensOC).BeginInit();
            SuspendLayout();
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.ForeColor = Color.Black;
            lblFornecedor.Location = new Point(24, 284);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(82, 15);
            lblFornecedor.TabIndex = 0;
            lblFornecedor.Text = "FORNECEDOR";
            // 
            // txtFornecedor_oc
            // 
            txtFornecedor_oc.Location = new Point(24, 302);
            txtFornecedor_oc.Name = "txtFornecedor_oc";
            txtFornecedor_oc.Size = new Size(365, 23);
            txtFornecedor_oc.TabIndex = 1;
            // 
            // lblComprador
            // 
            lblComprador.AutoSize = true;
            lblComprador.ForeColor = Color.Black;
            lblComprador.Location = new Point(24, 224);
            lblComprador.Name = "lblComprador";
            lblComprador.Size = new Size(81, 15);
            lblComprador.TabIndex = 2;
            lblComprador.Text = "COMPRADOR";
            // 
            // txtComprador
            // 
            txtComprador.Location = new Point(24, 242);
            txtComprador.Name = "txtComprador";
            txtComprador.Size = new Size(365, 23);
            txtComprador.TabIndex = 3;
            // 
            // lblNumeroOC
            // 
            lblNumeroOC.AutoSize = true;
            lblNumeroOC.ForeColor = Color.Black;
            lblNumeroOC.Location = new Point(24, 172);
            lblNumeroOC.Name = "lblNumeroOC";
            lblNumeroOC.Size = new Size(41, 15);
            lblNumeroOC.TabIndex = 4;
            lblNumeroOC.Text = "Nº OC";
            // 
            // dgvItensOC
            // 
            dgvItensOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensOC.Location = new Point(441, 35);
            dgvItensOC.Name = "dgvItensOC";
            dgvItensOC.Size = new Size(722, 530);
            dgvItensOC.TabIndex = 6;
            // 
            // txtNumeroOC
            // 
            txtNumeroOC.BackColor = SystemColors.Window;
            txtNumeroOC.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumeroOC.ForeColor = Color.MidnightBlue;
            txtNumeroOC.Location = new Point(24, 190);
            txtNumeroOC.Multiline = true;
            txtNumeroOC.Name = "txtNumeroOC";
            txtNumeroOC.Size = new Size(105, 23);
            txtNumeroOC.TabIndex = 7;
            txtNumeroOC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDataOC
            // 
            txtDataOC.Location = new Point(284, 190);
            txtDataOC.Name = "txtDataOC";
            txtDataOC.Size = new Size(105, 23);
            txtDataOC.TabIndex = 9;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.ForeColor = Color.Black;
            lblData.Location = new Point(284, 172);
            lblData.Name = "lblData";
            lblData.Size = new Size(36, 15);
            lblData.TabIndex = 8;
            lblData.Text = "DATA";
            // 
            // lblTotalOC
            // 
            lblTotalOC.Location = new Point(24, 467);
            lblTotalOC.Name = "lblTotalOC";
            lblTotalOC.Size = new Size(105, 23);
            lblTotalOC.TabIndex = 10;
            // 
            // btnSalvarOC
            // 
            btnSalvarOC.ForeColor = Color.Black;
            btnSalvarOC.Location = new Point(125, 531);
            btnSalvarOC.Name = "btnSalvarOC";
            btnSalvarOC.Size = new Size(75, 39);
            btnSalvarOC.TabIndex = 11;
            btnSalvarOC.Text = "CRIAR OC";
            btnSalvarOC.UseVisualStyleBackColor = true;
            btnSalvarOC.Click += btnSalvarOC_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(24, 449);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "TOTAL";
            // 
            // txtFreteOC
            // 
            txtFreteOC.Location = new Point(24, 412);
            txtFreteOC.Name = "txtFreteOC";
            txtFreteOC.Size = new Size(105, 23);
            txtFreteOC.TabIndex = 13;
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.ForeColor = Color.Black;
            lblPagamento.Location = new Point(248, 394);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(78, 15);
            lblPagamento.TabIndex = 16;
            lblPagamento.Text = "PAGAMENTO";
            // 
            // cbPagamentoOC
            // 
            cbPagamentoOC.FormattingEnabled = true;
            cbPagamentoOC.Location = new Point(248, 412);
            cbPagamentoOC.Name = "cbPagamentoOC";
            cbPagamentoOC.Size = new Size(141, 23);
            cbPagamentoOC.TabIndex = 17;
            // 
            // btnCriarSKU_OC
            // 
            btnCriarSKU_OC.ForeColor = Color.Black;
            btnCriarSKU_OC.Location = new Point(222, 531);
            btnCriarSKU_OC.Name = "btnCriarSKU_OC";
            btnCriarSKU_OC.Size = new Size(75, 39);
            btnCriarSKU_OC.TabIndex = 18;
            btnCriarSKU_OC.Text = "CRIAR SKU";
            btnCriarSKU_OC.UseVisualStyleBackColor = true;
            btnCriarSKU_OC.Click += btnCriarSKU_OC_Click;
            // 
            // txtFornecedorCNPJ_OC
            // 
            txtFornecedorCNPJ_OC.Location = new Point(24, 357);
            txtFornecedorCNPJ_OC.Name = "txtFornecedorCNPJ_OC";
            txtFornecedorCNPJ_OC.Size = new Size(147, 23);
            txtFornecedorCNPJ_OC.TabIndex = 19;
            // 
            // lblFrete
            // 
            lblFrete.AutoSize = true;
            lblFrete.ForeColor = Color.Black;
            lblFrete.Location = new Point(24, 394);
            lblFrete.Name = "lblFrete";
            lblFrete.Size = new Size(39, 15);
            lblFrete.TabIndex = 14;
            lblFrete.Text = "FRETE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 339);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 20;
            label1.Text = "CNPJ FORNECEDOR";
            // 
            // txtRazaoSocialZooka_OC
            // 
            txtRazaoSocialZooka_OC.Location = new Point(24, 64);
            txtRazaoSocialZooka_OC.Name = "txtRazaoSocialZooka_OC";
            txtRazaoSocialZooka_OC.Size = new Size(365, 23);
            txtRazaoSocialZooka_OC.TabIndex = 22;
            // 
            // txtCNPJZooka_OC
            // 
            txtCNPJZooka_OC.Location = new Point(24, 93);
            txtCNPJZooka_OC.Name = "txtCNPJZooka_OC";
            txtCNPJZooka_OC.Size = new Size(147, 23);
            txtCNPJZooka_OC.TabIndex = 23;
            // 
            // txtNomeFantasiaZooka_OC
            // 
            txtNomeFantasiaZooka_OC.Location = new Point(24, 35);
            txtNomeFantasiaZooka_OC.Name = "txtNomeFantasiaZooka_OC";
            txtNomeFantasiaZooka_OC.Size = new Size(105, 23);
            txtNomeFantasiaZooka_OC.TabIndex = 24;
            // 
            // ordem_de_compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 651);
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
    }
}