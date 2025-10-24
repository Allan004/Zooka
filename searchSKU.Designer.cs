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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchSKU));
            dgvSKU_search = new DataGridView();
            btnSKU_editar = new Button();
            btnSKU_des_atv = new Button();
            txtSKUCad_search = new TextBox();
            btnCriarSku_Search = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dgvSKU_search.Location = new Point(24, 153);
            dgvSKU_search.Name = "dgvSKU_search";
            dgvSKU_search.Size = new Size(891, 456);
            dgvSKU_search.TabIndex = 0;
            // 
            // btnSKU_editar
            // 
            btnSKU_editar.BackColor = Color.Transparent;
            btnSKU_editar.BackgroundImage = (Image)resources.GetObject("btnSKU_editar.BackgroundImage");
            btnSKU_editar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSKU_editar.FlatAppearance.BorderSize = 0;
            btnSKU_editar.FlatStyle = FlatStyle.Flat;
            btnSKU_editar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSKU_editar.ForeColor = Color.White;
            btnSKU_editar.Location = new Point(504, 628);
            btnSKU_editar.Name = "btnSKU_editar";
            btnSKU_editar.Size = new Size(110, 34);
            btnSKU_editar.TabIndex = 9;
            btnSKU_editar.Text = "Editar";
            btnSKU_editar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_editar.UseCompatibleTextRendering = true;
            btnSKU_editar.UseVisualStyleBackColor = false;
            btnSKU_editar.Click += btnSKU_editar_Click;
            // 
            // btnSKU_des_atv
            // 
            btnSKU_des_atv.BackColor = Color.Transparent;
            btnSKU_des_atv.BackgroundImage = (Image)resources.GetObject("btnSKU_des_atv.BackgroundImage");
            btnSKU_des_atv.BackgroundImageLayout = ImageLayout.Stretch;
            btnSKU_des_atv.FlatAppearance.BorderSize = 0;
            btnSKU_des_atv.FlatStyle = FlatStyle.Flat;
            btnSKU_des_atv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSKU_des_atv.ForeColor = Color.Black;
            btnSKU_des_atv.Location = new Point(738, 628);
            btnSKU_des_atv.Name = "btnSKU_des_atv";
            btnSKU_des_atv.Size = new Size(174, 34);
            btnSKU_des_atv.TabIndex = 10;
            btnSKU_des_atv.Text = "Desativar  /  Ativar";
            btnSKU_des_atv.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_des_atv.UseCompatibleTextRendering = true;
            btnSKU_des_atv.UseVisualStyleBackColor = false;
            btnSKU_des_atv.Click += btnSKU_des_atv_Click;
            // 
            // txtSKUCad_search
            // 
            txtSKUCad_search.Location = new Point(24, 124);
            txtSKUCad_search.Name = "txtSKUCad_search";
            txtSKUCad_search.Size = new Size(891, 23);
            txtSKUCad_search.TabIndex = 11;
            // 
            // btnCriarSku_Search
            // 
            btnCriarSku_Search.BackColor = Color.Transparent;
            btnCriarSku_Search.BackgroundImage = (Image)resources.GetObject("btnCriarSku_Search.BackgroundImage");
            btnCriarSku_Search.BackgroundImageLayout = ImageLayout.Stretch;
            btnCriarSku_Search.FlatAppearance.BorderSize = 0;
            btnCriarSku_Search.FlatStyle = FlatStyle.Flat;
            btnCriarSku_Search.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCriarSku_Search.ForeColor = Color.White;
            btnCriarSku_Search.Location = new Point(622, 628);
            btnCriarSku_Search.Name = "btnCriarSku_Search";
            btnCriarSku_Search.Size = new Size(110, 34);
            btnCriarSku_Search.TabIndex = 12;
            btnCriarSku_Search.Text = "Criar SKU";
            btnCriarSku_Search.TextAlign = ContentAlignment.BottomCenter;
            btnCriarSku_Search.UseCompatibleTextRendering = true;
            btnCriarSku_Search.UseVisualStyleBackColor = false;
            btnCriarSku_Search.Click += btnCriarSku_Search_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 94);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(366, 30);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 15;
            label1.Text = "Consulta SKU";
            // 
            // searchSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 671);
            Controls.Add(panel1);
            Controls.Add(btnCriarSku_Search);
            Controls.Add(txtSKUCad_search);
            Controls.Add(btnSKU_des_atv);
            Controls.Add(dgvSKU_search);
            Controls.Add(btnSKU_editar);
            Name = "searchSKU";
            Text = "SKU Cadastrados";
            Load += searchSKU_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSKU_search).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSKU_search;
        private Button btnSKU_editar;
        private Button btnSKU_des_atv;
        private TextBox txtSKUCad_search;
        private Button btnCriarSku_Search;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}