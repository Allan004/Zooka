namespace Zooka
{
    partial class searchSKU
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
            dgvSKU_search = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).BeginInit();
            SuspendLayout();
            // 
            // dgvSKU_search
            // 
            dgvSKU_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSKU_search.Location = new Point(24, 104);
            dgvSKU_search.Name = "dgvSKU_search";
            dgvSKU_search.Size = new Size(499, 446);
            dgvSKU_search.TabIndex = 0;
            // 
            // searchSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 571);
            Controls.Add(dgvSKU_search);
            Name = "searchSKU";
            Text = "SKU Cadastrados";
            Load += searchSKU_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSKU_search;
    }
}