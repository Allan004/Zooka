namespace Zooka
{
    partial class ConsultaFornecedor
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
            dtgCliente = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCliente).BeginInit();
            SuspendLayout();
            // 
            // dtgCliente
            // 
            dtgCliente.BackgroundColor = SystemColors.ActiveBorder;
            dtgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCliente.Dock = DockStyle.Bottom;
            dtgCliente.GridColor = Color.FromArgb(255, 241, 201);
            dtgCliente.Location = new Point(0, 38);
            dtgCliente.Name = "dtgCliente";
            dtgCliente.Size = new Size(1362, 421);
            dtgCliente.TabIndex = 0;
            dtgCliente.CellContentClick += dtgCliente_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 32);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(827, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(977, 3);
            button3.Name = "button3";
            button3.Size = new Size(113, 31);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1127, 3);
            button4.Name = "button4";
            button4.Size = new Size(113, 31);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ConsultaFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(34, 61, 79);
            ClientSize = new Size(1362, 459);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dtgCliente);
            Name = "ConsultaFornecedor";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)dtgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgCliente;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}