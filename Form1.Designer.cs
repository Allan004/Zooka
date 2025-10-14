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
            menuStrip1 = new MenuStrip();
            cADASTROSToolStripMenuItem = new ToolStripMenuItem();
            cadastroUsuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastroClienteToolStripMenuItem = new ToolStripMenuItem();
            cadastroPetToolStripMenuItem = new ToolStripMenuItem();
            cadastroFuncionarioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeSKUToolStripMenuItem = new ToolStripMenuItem();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTROSToolStripMenuItem, estoqueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            cADASTROSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroUsuarioToolStripMenuItem, cadastroClienteToolStripMenuItem, cadastroPetToolStripMenuItem, cadastroFuncionarioToolStripMenuItem, cadastroDeSKUToolStripMenuItem, agendaToolStripMenuItem, loginToolStripMenuItem });
            cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            cADASTROSToolStripMenuItem.Size = new Size(86, 20);
            cADASTROSToolStripMenuItem.Text = "CADASTROS";
            cADASTROSToolStripMenuItem.Click += cADASTROSToolStripMenuItem_Click;
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            cadastroUsuarioToolStripMenuItem.Size = new Size(187, 22);
            cadastroUsuarioToolStripMenuItem.Text = "Cadastro Usuario";
            cadastroUsuarioToolStripMenuItem.Click += cadastroUsuarioToolStripMenuItem_Click;
            // 
            // cadastroClienteToolStripMenuItem
            // 
            cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            cadastroClienteToolStripMenuItem.Size = new Size(187, 22);
            cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            cadastroClienteToolStripMenuItem.Click += cadastroClienteToolStripMenuItem_Click;
            // 
            // cadastroPetToolStripMenuItem
            // 
            cadastroPetToolStripMenuItem.Name = "cadastroPetToolStripMenuItem";
            cadastroPetToolStripMenuItem.Size = new Size(187, 22);
            cadastroPetToolStripMenuItem.Text = "Cadastro Pet";
            cadastroPetToolStripMenuItem.Click += cadastroPetToolStripMenuItem_Click;
            // 
            // cadastroFuncionarioToolStripMenuItem
            // 
            cadastroFuncionarioToolStripMenuItem.Name = "cadastroFuncionarioToolStripMenuItem";
            cadastroFuncionarioToolStripMenuItem.Size = new Size(187, 22);
            cadastroFuncionarioToolStripMenuItem.Text = "Cadastro Funcionario";
            cadastroFuncionarioToolStripMenuItem.Click += cadastroFuncionarioToolStripMenuItem_Click;
            // 
            // cadastroDeSKUToolStripMenuItem
            // 
            cadastroDeSKUToolStripMenuItem.Name = "cadastroDeSKUToolStripMenuItem";
            cadastroDeSKUToolStripMenuItem.Size = new Size(187, 22);
            cadastroDeSKUToolStripMenuItem.Text = "Cadastro de SKU";
            cadastroDeSKUToolStripMenuItem.Click += cadastroDeSKUToolStripMenuItem_Click;
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(187, 22);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(187, 22);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(69, 20);
            estoqueToolStripMenuItem.Text = "ESTOQUE";
            estoqueToolStripMenuItem.Click += estoqueToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1184, 657);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTROSToolStripMenuItem;
        private ToolStripMenuItem cadastroUsuarioToolStripMenuItem;
        private ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private ToolStripMenuItem cadastroPetToolStripMenuItem;
        private ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private ToolStripMenuItem cadastroDeSKUToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
