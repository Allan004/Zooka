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
            btnConsulta = new Button();
            btnCliente = new Button();
            btnPet = new Button();
            btnProfissional = new Button();
            btnUsuario = new Button();
            btnCadastroServico = new Button();
            panel1 = new Panel();
            btnSku = new Button();
            btnCadastroFornecedor = new Button();
            btnConsultaSku = new Button();
            btnConsultaServico = new Button();
            btnConsultaUsuario = new Button();
            btnConsultaProfissional = new Button();
            btnConsultaPet = new Button();
            btnConsultaFornecedor = new Button();
            btnConsultaCliente = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            trocarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            atalhoCadastroCliente = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 61, 79);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(218, 50);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 61, 79);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(0, 50);
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
            button3.BackColor = Color.FromArgb(34, 61, 79);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 14.25F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(0, 125);
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
            btnEstoque.BackColor = Color.FromArgb(34, 61, 79);
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnEstoque.ForeColor = SystemColors.Control;
            btnEstoque.Location = new Point(0, 200);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(218, 75);
            btnEstoque.TabIndex = 6;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Visible = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // BtnOrdemdecompra
            // 
            BtnOrdemdecompra.BackColor = Color.FromArgb(34, 61, 79);
            BtnOrdemdecompra.FlatAppearance.BorderSize = 0;
            BtnOrdemdecompra.FlatStyle = FlatStyle.Flat;
            BtnOrdemdecompra.Font = new Font("Arial Rounded MT Bold", 14.25F);
            BtnOrdemdecompra.ForeColor = SystemColors.Control;
            BtnOrdemdecompra.Location = new Point(0, 275);
            BtnOrdemdecompra.Name = "BtnOrdemdecompra";
            BtnOrdemdecompra.Size = new Size(218, 75);
            BtnOrdemdecompra.TabIndex = 7;
            BtnOrdemdecompra.Text = "Ordem de Compra";
            BtnOrdemdecompra.UseVisualStyleBackColor = false;
            BtnOrdemdecompra.Visible = false;
            BtnOrdemdecompra.Click += BtnOrdemdecompra_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.FromArgb(34, 61, 79);
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnConsulta.Location = new Point(0, 355);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(218, 75);
            btnConsulta.TabIndex = 9;
            btnConsulta.Text = "Consultas";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Visible = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(50, 85, 104);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCliente.ForeColor = SystemColors.Control;
            btnCliente.Location = new Point(219, 125);
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
            btnPet.BackColor = Color.FromArgb(50, 85, 104);
            btnPet.FlatAppearance.BorderSize = 0;
            btnPet.FlatStyle = FlatStyle.Flat;
            btnPet.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnPet.ForeColor = SystemColors.Control;
            btnPet.Location = new Point(219, 150);
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
            btnProfissional.BackColor = Color.FromArgb(50, 85, 104);
            btnProfissional.FlatAppearance.BorderSize = 0;
            btnProfissional.FlatStyle = FlatStyle.Flat;
            btnProfissional.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnProfissional.ForeColor = SystemColors.Control;
            btnProfissional.Location = new Point(219, 175);
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
            btnUsuario.BackColor = Color.FromArgb(50, 85, 104);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Location = new Point(219, 200);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(165, 25);
            btnUsuario.TabIndex = 12;
            btnUsuario.Text = "Cadastro Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Visible = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnCadastroServico
            // 
            btnCadastroServico.BackColor = Color.FromArgb(50, 85, 104);
            btnCadastroServico.FlatAppearance.BorderSize = 0;
            btnCadastroServico.FlatStyle = FlatStyle.Flat;
            btnCadastroServico.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCadastroServico.ForeColor = SystemColors.Control;
            btnCadastroServico.Location = new Point(219, 250);
            btnCadastroServico.Name = "btnCadastroServico";
            btnCadastroServico.Size = new Size(165, 25);
            btnCadastroServico.TabIndex = 14;
            btnCadastroServico.Text = "Cadastro Serviço";
            btnCadastroServico.UseVisualStyleBackColor = false;
            btnCadastroServico.Visible = false;
            btnCadastroServico.Click += btnCadastroServico_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 61, 79);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 3000);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // btnSku
            // 
            btnSku.BackColor = Color.FromArgb(50, 85, 104);
            btnSku.FlatAppearance.BorderSize = 0;
            btnSku.FlatStyle = FlatStyle.Flat;
            btnSku.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnSku.ForeColor = SystemColors.Control;
            btnSku.Location = new Point(219, 225);
            btnSku.Name = "btnSku";
            btnSku.Size = new Size(165, 25);
            btnSku.TabIndex = 14;
            btnSku.Text = "CadastroSku";
            btnSku.UseVisualStyleBackColor = false;
            btnSku.Visible = false;
            btnSku.Click += btnSku_Click;
            // 
            // btnCadastroFornecedor
            // 
            btnCadastroFornecedor.BackColor = Color.FromArgb(50, 85, 104);
            btnCadastroFornecedor.FlatAppearance.BorderSize = 0;
            btnCadastroFornecedor.FlatStyle = FlatStyle.Flat;
            btnCadastroFornecedor.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCadastroFornecedor.ForeColor = SystemColors.Control;
            btnCadastroFornecedor.Location = new Point(219, 275);
            btnCadastroFornecedor.Name = "btnCadastroFornecedor";
            btnCadastroFornecedor.Size = new Size(165, 25);
            btnCadastroFornecedor.TabIndex = 11;
            btnCadastroFornecedor.Text = "Cadastro Fornecedor";
            btnCadastroFornecedor.UseVisualStyleBackColor = false;
            btnCadastroFornecedor.Visible = false;
            btnCadastroFornecedor.Click += btnCadastroFornecedor_Click;
            // 
            // btnConsultaSku
            // 
            btnConsultaSku.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaSku.FlatAppearance.BorderSize = 0;
            btnConsultaSku.FlatStyle = FlatStyle.Flat;
            btnConsultaSku.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaSku.ForeColor = SystemColors.Control;
            btnConsultaSku.Location = new Point(219, 455);
            btnConsultaSku.Name = "btnConsultaSku";
            btnConsultaSku.Size = new Size(165, 25);
            btnConsultaSku.TabIndex = 25;
            btnConsultaSku.Text = "Consulta Sku";
            btnConsultaSku.UseVisualStyleBackColor = false;
            btnConsultaSku.Visible = false;
            btnConsultaSku.Click += btnConsultaSku_Click;
            // 
            // btnConsultaServico
            // 
            btnConsultaServico.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaServico.FlatAppearance.BorderSize = 0;
            btnConsultaServico.FlatStyle = FlatStyle.Flat;
            btnConsultaServico.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaServico.ForeColor = SystemColors.Control;
            btnConsultaServico.Location = new Point(219, 480);
            btnConsultaServico.Name = "btnConsultaServico";
            btnConsultaServico.Size = new Size(165, 25);
            btnConsultaServico.TabIndex = 26;
            btnConsultaServico.Text = "Consulta Serviço";
            btnConsultaServico.UseVisualStyleBackColor = false;
            btnConsultaServico.Visible = false;
            btnConsultaServico.Click += btnConsultaServico_Click;
            // 
            // btnConsultaUsuario
            // 
            btnConsultaUsuario.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaUsuario.FlatAppearance.BorderSize = 0;
            btnConsultaUsuario.FlatStyle = FlatStyle.Flat;
            btnConsultaUsuario.Location = new Point(219, 430);
            btnConsultaUsuario.Name = "btnConsultaUsuario";
            btnConsultaUsuario.Size = new Size(165, 25);
            btnConsultaUsuario.TabIndex = 22;
            btnConsultaUsuario.Text = "Consulta Usuario";
            btnConsultaUsuario.UseVisualStyleBackColor = false;
            btnConsultaUsuario.Visible = false;
            btnConsultaUsuario.Click += btnConsultaUsuario_Click;
            // 
            // btnConsultaProfissional
            // 
            btnConsultaProfissional.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaProfissional.FlatAppearance.BorderSize = 0;
            btnConsultaProfissional.FlatStyle = FlatStyle.Flat;
            btnConsultaProfissional.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaProfissional.ForeColor = SystemColors.Control;
            btnConsultaProfissional.Location = new Point(219, 405);
            btnConsultaProfissional.Name = "btnConsultaProfissional";
            btnConsultaProfissional.Size = new Size(165, 25);
            btnConsultaProfissional.TabIndex = 23;
            btnConsultaProfissional.Text = "Consulta Profissional";
            btnConsultaProfissional.UseVisualStyleBackColor = false;
            btnConsultaProfissional.Visible = false;
            btnConsultaProfissional.Click += btnConsultaProfissional_Click;
            // 
            // btnConsultaPet
            // 
            btnConsultaPet.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaPet.FlatAppearance.BorderSize = 0;
            btnConsultaPet.FlatStyle = FlatStyle.Flat;
            btnConsultaPet.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaPet.ForeColor = SystemColors.Control;
            btnConsultaPet.Location = new Point(219, 380);
            btnConsultaPet.Name = "btnConsultaPet";
            btnConsultaPet.Size = new Size(165, 25);
            btnConsultaPet.TabIndex = 24;
            btnConsultaPet.Text = "Consulta Pet";
            btnConsultaPet.UseVisualStyleBackColor = false;
            btnConsultaPet.Visible = false;
            btnConsultaPet.Click += btnConsultaPet_Click;
            // 
            // btnConsultaFornecedor
            // 
            btnConsultaFornecedor.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaFornecedor.FlatAppearance.BorderSize = 0;
            btnConsultaFornecedor.FlatStyle = FlatStyle.Flat;
            btnConsultaFornecedor.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaFornecedor.ForeColor = SystemColors.Control;
            btnConsultaFornecedor.Location = new Point(219, 505);
            btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            btnConsultaFornecedor.Size = new Size(165, 25);
            btnConsultaFornecedor.TabIndex = 20;
            btnConsultaFornecedor.Text = "Consulta Fornecedor";
            btnConsultaFornecedor.UseVisualStyleBackColor = false;
            btnConsultaFornecedor.Visible = false;
            btnConsultaFornecedor.Click += btnConsultaFornecedor_Click;
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.BackColor = Color.FromArgb(50, 85, 104);
            btnConsultaCliente.FlatAppearance.BorderSize = 0;
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnConsultaCliente.ForeColor = SystemColors.Control;
            btnConsultaCliente.Location = new Point(219, 355);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(165, 25);
            btnConsultaCliente.TabIndex = 21;
            btnConsultaCliente.Text = "Consulta Cliente";
            btnConsultaCliente.UseVisualStyleBackColor = false;
            btnConsultaCliente.Visible = false;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(34, 61, 79);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(218, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1686, 50);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.BackgroundImage = Properties.Resources.submenulogin;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { trocarUsuarioToolStripMenuItem, sairToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(200, 50);
            toolStripMenuItem1.Text = "Logout";
            toolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // trocarUsuarioToolStripMenuItem
            // 
            trocarUsuarioToolStripMenuItem.AutoSize = false;
            trocarUsuarioToolStripMenuItem.BackColor = Color.FromArgb(145, 158, 167);
            trocarUsuarioToolStripMenuItem.ForeColor = Color.White;
            trocarUsuarioToolStripMenuItem.Name = "trocarUsuarioToolStripMenuItem";
            trocarUsuarioToolStripMenuItem.Size = new Size(200, 22);
            trocarUsuarioToolStripMenuItem.Text = "Trocar Usuario";
            trocarUsuarioToolStripMenuItem.Click += trocarUsuarioToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.AutoSize = false;
            sairToolStripMenuItem.BackColor = Color.FromArgb(34, 61, 79);
            sairToolStripMenuItem.ForeColor = Color.White;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(200, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // atalhoCadastroCliente
            // 
            atalhoCadastroCliente.BackColor = Color.FromArgb(237, 241, 243);
            atalhoCadastroCliente.BackgroundImage = (Image)resources.GetObject("atalhoCadastroCliente.BackgroundImage");
            atalhoCadastroCliente.BackgroundImageLayout = ImageLayout.Stretch;
            atalhoCadastroCliente.FlatAppearance.BorderSize = 0;
            atalhoCadastroCliente.FlatStyle = FlatStyle.Flat;
            atalhoCadastroCliente.Location = new Point(414, 200);
            atalhoCadastroCliente.Name = "atalhoCadastroCliente";
            atalhoCadastroCliente.Size = new Size(150, 150);
            atalhoCadastroCliente.TabIndex = 2;
            atalhoCadastroCliente.UseVisualStyleBackColor = false;
            atalhoCadastroCliente.Click += atalhoCadastroCliente_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(237, 241, 243);
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(644, 200);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 40;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(237, 241, 243);
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(882, 200);
            button5.Name = "button5";
            button5.Size = new Size(150, 150);
            button5.TabIndex = 41;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(237, 241, 243);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(1586, 200);
            button6.Name = "button6";
            button6.Size = new Size(150, 150);
            button6.TabIndex = 44;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(237, 241, 243);
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1348, 200);
            button7.Name = "button7";
            button7.Size = new Size(150, 150);
            button7.TabIndex = 43;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(237, 241, 243);
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(1118, 200);
            button8.Name = "button8";
            button8.Size = new Size(150, 150);
            button8.TabIndex = 42;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(34, 61, 79);
            ClientSize = new Size(1904, 1041);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(atalhoCadastroCliente);
            Controls.Add(btnConsultaSku);
            Controls.Add(btnConsultaServico);
            Controls.Add(btnConsultaUsuario);
            Controls.Add(btnConsultaProfissional);
            Controls.Add(btnConsultaPet);
            Controls.Add(btnConsultaFornecedor);
            Controls.Add(btnConsultaCliente);
            Controls.Add(btnSku);
            Controls.Add(btnCadastroServico);
            Controls.Add(btnUsuario);
            Controls.Add(btnProfissional);
            Controls.Add(btnPet);
            Controls.Add(btnCadastroFornecedor);
            Controls.Add(btnCliente);
            Controls.Add(btnConsulta);
            Controls.Add(BtnOrdemdecompra);
            Controls.Add(btnEstoque);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Rounded MT Bold", 9.75F);
            ForeColor = SystemColors.Control;
            IsMdiContainer = true;
            Name = "Form1";
            Padding = new Padding(218, 0, 0, 0);
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnEstoque;
        private Button BtnOrdemdecompra;
        private Button btnConsulta;
        private Button btnCliente;
        private Button btnPet;
        private Button btnProfissional;
        private Button btnUsuario;
        private Button btnCadastroServico;
        private Panel panel1;
        private Button btnSku;
        private Button btnCadastroFornecedor;
        private Button btnConsultaSku;
        private Button btnConsultaServico;
        private Button btnConsultaUsuario;
        private Button btnConsultaProfissional;
        private Button btnConsultaPet;
        private Button btnConsultaFornecedor;
        private Button btnConsultaCliente;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem trocarUsuarioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button atalhoCadastroCliente;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
    }
}
