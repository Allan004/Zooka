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
            ((System.ComponentModel.ISupportInitialize)dgvItensOC).BeginInit();
            SuspendLayout();
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(24, 93);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(82, 15);
            lblFornecedor.TabIndex = 0;
            lblFornecedor.Text = "FORNECEDOR";
            // 
            // txtFornecedor_oc
            // 
            txtFornecedor_oc.Location = new Point(24, 111);
            txtFornecedor_oc.Name = "txtFornecedor_oc";
            txtFornecedor_oc.Size = new Size(365, 23);
            txtFornecedor_oc.TabIndex = 1;
            // 
            // lblComprador
            // 
            lblComprador.AutoSize = true;
            lblComprador.Location = new Point(134, 17);
            lblComprador.Name = "lblComprador";
            lblComprador.Size = new Size(81, 15);
            lblComprador.TabIndex = 2;
            lblComprador.Text = "COMPRADOR";
            // 
            // txtComprador
            // 
            txtComprador.Location = new Point(134, 35);
            txtComprador.Name = "txtComprador";
            txtComprador.Size = new Size(255, 23);
            txtComprador.TabIndex = 3;
            // 
            // lblNumeroOC
            // 
            lblNumeroOC.AutoSize = true;
            lblNumeroOC.Location = new Point(24, 17);
            lblNumeroOC.Name = "lblNumeroOC";
            lblNumeroOC.Size = new Size(41, 15);
            lblNumeroOC.TabIndex = 4;
            lblNumeroOC.Text = "Nº OC";
            // 
            // dgvItensOC
            // 
            dgvItensOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensOC.Location = new Point(467, 35);
            dgvItensOC.Name = "dgvItensOC";
            dgvItensOC.Size = new Size(270, 231);
            dgvItensOC.TabIndex = 6;
            // 
            // txtNumeroOC
            // 
            txtNumeroOC.BackColor = SystemColors.Window;
            txtNumeroOC.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumeroOC.ForeColor = Color.MidnightBlue;
            txtNumeroOC.Location = new Point(24, 35);
            txtNumeroOC.Multiline = true;
            txtNumeroOC.Name = "txtNumeroOC";
            txtNumeroOC.Size = new Size(65, 23);
            txtNumeroOC.TabIndex = 7;
            txtNumeroOC.TextAlign = HorizontalAlignment.Center;
            // 
            // ordem_de_compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeroOC);
            Controls.Add(dgvItensOC);
            Controls.Add(lblNumeroOC);
            Controls.Add(txtComprador);
            Controls.Add(lblComprador);
            Controls.Add(txtFornecedor_oc);
            Controls.Add(lblFornecedor);
            Name = "ordem_de_compra";
            Text = "ordem_de_compra";
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
    }
}