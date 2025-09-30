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
            btnSKU_cancelar = new Button();
            SuspendLayout();
            // 
            // btnSKU_cancelar
            // 
            btnSKU_cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSKU_cancelar.BackColor = Color.LightSteelBlue;
            btnSKU_cancelar.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_cancelar.ForeColor = Color.MidnightBlue;
            btnSKU_cancelar.Location = new Point(539, 302);
            btnSKU_cancelar.Name = "btnSKU_cancelar";
            btnSKU_cancelar.Size = new Size(76, 40);
            btnSKU_cancelar.TabIndex = 11;
            btnSKU_cancelar.Text = "CANCELAR";
            btnSKU_cancelar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_cancelar.UseCompatibleTextRendering = true;
            btnSKU_cancelar.UseVisualStyleBackColor = false;
            // 
            // lblSKU_id
            // 
            lblSKU_id.BackColor = Color.Transparent;
            lblSKU_id.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_id.ForeColor = Color.MidnightBlue;
            lblSKU_id.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_id.Location = new Point(164, 171);
            lblSKU_id.Name = "lblSKU_id";
            lblSKU_id.Size = new Size(53, 25);
            lblSKU_id.TabIndex = 0;
            lblSKU_id.Text = "SKU";
            lblSKU_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSKU_id
            // 
            txtSKU_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSKU_id.BackColor = SystemColors.Window;
            txtSKU_id.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU_id.ForeColor = Color.MidnightBlue;
            txtSKU_id.Location = new Point(164, 199);
            txtSKU_id.Multiline = true;
            txtSKU_id.Name = "txtSKU_id";
            txtSKU_id.Size = new Size(93, 23);
            txtSKU_id.TabIndex = 1;
            txtSKU_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSKU_descricao
            // 
            txtSKU_descricao.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSKU_descricao.ForeColor = Color.MidnightBlue;
            txtSKU_descricao.Location = new Point(289, 199);
            txtSKU_descricao.Multiline = true;
            txtSKU_descricao.Name = "txtSKU_descricao";
            txtSKU_descricao.Size = new Size(360, 23);
            txtSKU_descricao.TabIndex = 3;
            txtSKU_descricao.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSKU_descricao
            // 
            lblSKU_descricao.BackColor = Color.Transparent;
            lblSKU_descricao.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_descricao.ForeColor = Color.MidnightBlue;
            lblSKU_descricao.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_descricao.Location = new Point(289, 171);
            lblSKU_descricao.Name = "lblSKU_descricao";
            lblSKU_descricao.Size = new Size(119, 25);
            lblSKU_descricao.TabIndex = 2;
            lblSKU_descricao.Text = "DESCRIÇÃO";
            lblSKU_descricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSKU_udm
            // 
            lblSKU_udm.BackColor = Color.Transparent;
            lblSKU_udm.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_udm.ForeColor = Color.MidnightBlue;
            lblSKU_udm.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_udm.Location = new Point(685, 171);
            lblSKU_udm.Name = "lblSKU_udm";
            lblSKU_udm.Size = new Size(53, 25);
            lblSKU_udm.TabIndex = 4;
            lblSKU_udm.Text = "UDM";
            lblSKU_udm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSKU_estoque
            // 
            lblSKU_estoque.BackColor = Color.Transparent;
            lblSKU_estoque.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSKU_estoque.ForeColor = Color.MidnightBlue;
            lblSKU_estoque.ImageAlign = ContentAlignment.MiddleLeft;
            lblSKU_estoque.Location = new Point(810, 171);
            lblSKU_estoque.Name = "lblSKU_estoque";
            lblSKU_estoque.Size = new Size(93, 25);
            lblSKU_estoque.TabIndex = 6;
            lblSKU_estoque.Text = "ESTOQUE";
            lblSKU_estoque.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSKU_criar
            // 
            btnSKU_criar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSKU_criar.BackColor = Color.AliceBlue;
            btnSKU_criar.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_criar.ForeColor = Color.MidnightBlue;
            btnSKU_criar.Location = new Point(354, 302);
            btnSKU_criar.Name = "btnSKU_criar";
            btnSKU_criar.Size = new Size(76, 40);
            btnSKU_criar.TabIndex = 8;
            btnSKU_criar.Text = "CRIAR SKU";
            btnSKU_criar.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_criar.UseCompatibleTextRendering = true;
            btnSKU_criar.UseVisualStyleBackColor = false;
            btnSKU_criar.Click += btnSKU_criar_Click;
            // 
            // cbSKU_estoque
            // 
            cbSKU_estoque.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSKU_estoque.FormattingEnabled = true;
            cbSKU_estoque.Location = new Point(810, 199);
            cbSKU_estoque.Name = "cbSKU_estoque";
            cbSKU_estoque.Size = new Size(93, 23);
            cbSKU_estoque.TabIndex = 9;
            // 
            // cbSKU_udm
            // 
            cbSKU_udm.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSKU_udm.FormattingEnabled = true;
            cbSKU_udm.Location = new Point(685, 199);
            cbSKU_udm.Name = "cbSKU_udm";
            cbSKU_udm.Size = new Size(93, 23);
            cbSKU_udm.TabIndex = 10;
            // 
            // btnSKU_search
            // 
            btnSKU_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSKU_search.BackColor = Color.AliceBlue;
            btnSKU_search.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSKU_search.ForeColor = Color.MidnightBlue;
            btnSKU_search.Image = (Image)resources.GetObject("btnSKU_search.Image");
            btnSKU_search.Location = new Point(104, 190);
            btnSKU_search.Name = "btnSKU_search";
            btnSKU_search.Size = new Size(34, 32);
            btnSKU_search.TabIndex = 12;
            btnSKU_search.TextAlign = ContentAlignment.BottomCenter;
            btnSKU_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSKU_search.UseCompatibleTextRendering = true;
            btnSKU_search.UseVisualStyleBackColor = false;
            // 
            // CadastroSKU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = Properties.Resources.Design_sem_nome__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 450);
            Controls.Add(btnSKU_search);
            Controls.Add(btnSKU_cancelar);
            Controls.Add(cbSKU_udm);
            Controls.Add(cbSKU_estoque);
            Controls.Add(btnSKU_criar);
            Controls.Add(lblSKU_estoque);
            Controls.Add(lblSKU_udm);
            Controls.Add(txtSKU_descricao);
            Controls.Add(lblSKU_descricao);
            Controls.Add(txtSKU_id);
            Controls.Add(lblSKU_id);
            DoubleBuffered = true;
            Name = "CadastroSKU";
            Text = "Cadastro de SKU";
            Load += CadastroSKU_Load;
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
    }
}