namespace Zooka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnEstoque = new Button();
            BtnOrdemdecompra = new Button();
            button6 = new Button();
            button7 = new Button();
            btnCliente = new Button();
            btnPet = new Button();
            btnProfissional = new Button();
            btnUsuario = new Button();
            btnSku = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(251, 228, 178);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button2.Location = new Point(1, 55);
            button2.Name = "button2";
            button2.Size = new Size(218, 75);
            button2.TabIndex = 4;
            button2.Text = "Agenda";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(251, 228, 178);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button3.Location = new Point(1, 130);
            button3.Name = "button3";
            button3.Size = new Size(218, 75);
            button3.TabIndex = 5;
            button3.Text = "Cadastrar";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.FromArgb(251, 228, 178);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnEstoque.Location = new Point(1, 205);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(218, 75);
            btnEstoque.TabIndex = 6;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Visible = false;
            btnEstoque.Click += button4_Click;
            // 
            // BtnOrdemdecompra
            // 
            BtnOrdemdecompra.BackColor = Color.FromArgb(251, 228, 178);
            BtnOrdemdecompra.FlatStyle = FlatStyle.Flat;
            BtnOrdemdecompra.Font = new Font("Arial Rounded MT Bold", 14.25F);
            BtnOrdemdecompra.Location = new Point(1, 280);
            BtnOrdemdecompra.Name = "BtnOrdemdecompra";
            BtnOrdemdecompra.Size = new Size(218, 75);
            BtnOrdemdecompra.TabIndex = 7;
            BtnOrdemdecompra.Text = "Ordem de Compra";
            BtnOrdemdecompra.UseVisualStyleBackColor = false;
            BtnOrdemdecompra.Visible = false;
            BtnOrdemdecompra.Click += BtnOrdemdecompra_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(251, 228, 178);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button6.Location = new Point(1, 355);
            button6.Name = "button6";
            button6.Size = new Size(218, 75);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(251, 228, 178);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button7.Location = new Point(1, 430);
            button7.Name = "button7";
            button7.Size = new Size(218, 75);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(251, 228, 178);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCliente.Location = new Point(219, 130);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(165, 25);
            btnCliente.TabIndex = 11;
            btnCliente.Text = "Cadastro Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Visible = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnPet
            // 
            btnPet.BackColor = Color.FromArgb(251, 228, 178);
            btnPet.FlatStyle = FlatStyle.Flat;
            btnPet.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnPet.Location = new Point(219, 155);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(165, 25);
            btnPet.TabIndex = 12;
            btnPet.Text = "Cadastro Pet";
            btnPet.UseVisualStyleBackColor = false;
            btnPet.Visible = false;
            btnPet.Click += button9_Click;
            // 
            // btnProfissional
            // 
            btnProfissional.BackColor = Color.FromArgb(251, 228, 178);
            btnProfissional.FlatStyle = FlatStyle.Flat;
            btnProfissional.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnProfissional.Location = new Point(219, 180);
            btnProfissional.Name = "btnProfissional";
            btnProfissional.Size = new Size(165, 25);
            btnProfissional.TabIndex = 12;
            btnProfissional.Text = "Cadastro Profissional";
            btnProfissional.UseVisualStyleBackColor = false;
            btnProfissional.Visible = false;
            btnProfissional.Click += btnProfissional_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(251, 228, 178);
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Location = new Point(219, 205);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(165, 25);
            btnUsuario.TabIndex = 12;
            btnUsuario.Text = "Cadastro Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Visible = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnSku
            // 
            btnSku.BackColor = Color.FromArgb(251, 228, 178);
            btnSku.FlatStyle = FlatStyle.Flat;
            btnSku.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnSku.Location = new Point(219, 205);
            btnSku.Name = "btnSku";
            btnSku.Size = new Size(165, 25);
            btnSku.TabIndex = 14;
            btnSku.Text = "CadastroSku";
            btnSku.UseVisualStyleBackColor = false;
            btnSku.Visible = false;
            btnSku.Click += btnSku_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 241, 201);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 3000);
            panel1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1155, 625);
            Controls.Add(btnSku);
            Controls.Add(btnUsuario);
            Controls.Add(btnProfissional);
            Controls.Add(btnPet);
            Controls.Add(btnCliente);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(BtnOrdemdecompra);
            Controls.Add(btnEstoque);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 9.75F);
            IsMdiContainer = true;
            Name = "Form1";
            Padding = new Padding(218, 0, 0, 0);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnEstoque;
        private Button BtnOrdemdecompra;
        private Button button6;
        private Button button7;
        private Button btnCliente;
        private Button btnPet;
        private Button btnProfissional;
        private Button btnUsuario;
        private Button btnSku;
        private Panel panel1;
    }
}
