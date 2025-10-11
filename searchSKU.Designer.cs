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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvSKU_search = new DataGridView();
            btnSKU_editar = new Button();
            btnSKU_des_atv = new Button();
            txtSKUCad_search = new TextBox();
            btnSKUCad_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).BeginInit();
            SuspendLayout();
            // 
            // dgvSKU_search
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSKU_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSKU_search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSKU_search.Location = new Point(24, 104);
            dgvSKU_search.Name = "dgvSKU_search";
            dgvSKU_search.Size = new Size(598, 446);
            dgvSKU_search.TabIndex = 0;
            // 
            // btnSKU_editar
            // 
            btnSKU_editar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSKU_editar.BackColor = Color.AliceBlue;
            btnSKU_editar.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_editar.ForeColor = Color.MidnightBlue;
            btnSKU_editar.Location = new Point(686, 510);
            btnSKU_editar.Name = "btnSKU_editar";
            btnSKU_editar.Size = new Size(76, 40);
            btnSKU_editar.TabIndex = 9;
            btnSKU_editar.Text = "EDITAR";
            btnSKU_editar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_editar.UseCompatibleTextRendering = true;
            btnSKU_editar.UseVisualStyleBackColor = false;
            btnSKU_editar.Click += btnSKU_editar_Click;
            // 
            // btnSKU_des_atv
            // 
            btnSKU_des_atv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSKU_des_atv.BackColor = Color.LightSteelBlue;
            btnSKU_des_atv.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_des_atv.ForeColor = Color.MidnightBlue;
            btnSKU_des_atv.Location = new Point(793, 510);
            btnSKU_des_atv.Name = "btnSKU_des_atv";
            btnSKU_des_atv.Size = new Size(120, 40);
            btnSKU_des_atv.TabIndex = 10;
            btnSKU_des_atv.Text = "DESATIVAR  /  ATIVAR";
            btnSKU_des_atv.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_des_atv.UseCompatibleTextRendering = true;
            btnSKU_des_atv.UseVisualStyleBackColor = false;
            btnSKU_des_atv.Click += btnSKU_des_atv_Click;
            // 
            // txtSKUCad_search
            // 
            txtSKUCad_search.Location = new Point(24, 75);
            txtSKUCad_search.Name = "txtSKUCad_search";
            txtSKUCad_search.Size = new Size(507, 23);
            txtSKUCad_search.TabIndex = 11;
            // 
            // btnSKUCad_search
            // 
            btnSKUCad_search.Location = new Point(537, 75);
            btnSKUCad_search.Name = "btnSKUCad_search";
            btnSKUCad_search.Size = new Size(85, 26);
            btnSKUCad_search.TabIndex = 12;
            btnSKUCad_search.Text = "PESQUISAR";
            btnSKUCad_search.UseVisualStyleBackColor = true;
            btnSKUCad_search.Click += btnSKUCad_search_Click;
            // 
            // searchSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 571);
            Controls.Add(btnSKUCad_search);
            Controls.Add(txtSKUCad_search);
            Controls.Add(btnSKU_des_atv);
            Controls.Add(btnSKU_editar);
            Controls.Add(dgvSKU_search);
            Name = "searchSKU";
            Text = "SKU Cadastrados";
            Load += searchSKU_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSKU_search;
        private Button btnSKU_editar;
        private Button btnSKU_des_atv;
        private TextBox txtSKUCad_search;
        private Button btnSKUCad_search;
    }
}