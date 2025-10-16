namespace Zooka
{
    partial class Servico
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


        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servico));
            txtrganimal = new MaskedTextBox();
            txt_Peso = new TextBox();
            txtnomepet = new TextBox();
            label1 = new Label();
            txtIdade = new TextBox();
            txtcpfcliente = new MaskedTextBox();
            boxRaca = new ComboBox();
            comboEspecie = new ComboBox();
            txtPelagem = new TextBox();
            boxSexo = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label9 = new Label();
            label4 = new Label();
            label6 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtrganimal
            // 
            txtrganimal.BorderStyle = BorderStyle.None;
            txtrganimal.Font = new Font("Segoe UI", 13F);
            txtrganimal.Location = new Point(641, 205);
            txtrganimal.Mask = "00.000.000-0";
            txtrganimal.Name = "txtrganimal";
            txtrganimal.Size = new Size(136, 24);
            txtrganimal.TabIndex = 2;
            // 
            // txt_Peso
            // 
            txt_Peso.BorderStyle = BorderStyle.None;
            txt_Peso.Font = new Font("Segoe UI", 13F);
            txt_Peso.Location = new Point(856, 295);
            txt_Peso.Name = "txt_Peso";
            txt_Peso.Size = new Size(194, 24);
            txt_Peso.TabIndex = 8;
            // 
            // txtnomepet
            // 
            txtnomepet.BorderStyle = BorderStyle.None;
            txtnomepet.Font = new Font("Segoe UI", 13F);
            txtnomepet.Location = new Point(228, 205);
            txtnomepet.Name = "txtnomepet";
            txtnomepet.Size = new Size(270, 24);
            txtnomepet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 241, 201);
            label1.Font = new Font("Arial Rounded MT Bold", 30F);
            label1.ForeColor = Color.FromArgb(215, 122, 40);
            label1.Location = new Point(403, 47);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO PET";
            // 
            // txtIdade
            // 
            txtIdade.BorderStyle = BorderStyle.None;
            txtIdade.Font = new Font("Segoe UI", 13F);
            txtIdade.Location = new Point(228, 295);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(70, 24);
            txtIdade.TabIndex = 5;
            // 
            // txtcpfcliente
            // 
            txtcpfcliente.BorderStyle = BorderStyle.None;
            txtcpfcliente.Font = new Font("Segoe UI", 13F);
            txtcpfcliente.Location = new Point(897, 205);
            txtcpfcliente.Mask = "000.000.000-00";
            txtcpfcliente.Name = "txtcpfcliente";
            txtcpfcliente.Size = new Size(153, 24);
            txtcpfcliente.TabIndex = 9;
            // 
            // boxRaca
            // 
            boxRaca.FlatStyle = FlatStyle.Flat;
            boxRaca.FormattingEnabled = true;
            boxRaca.Items.AddRange(new object[] { "Labrador Retriever", "Siamês", "Golden Retriever", "Persa", "Bulldog Francês", "Maine Coon", "Pastor Alemão", "Ragdoll", "Poodle", "Bengal", "Beagle", "Sphynx", "Shih Tzu", "British Shorthair", "Chihuahua", "Abissínio", "Dachshund", "Birmanês", "Border Collie", "Scottish Fold", "Boxer", "Russian Blue", "Cocker Spaniel", "Savannah", "Husky Siberiano", "Oriental Shorthair", "Pug", "Chartreux", "Yorkshire Terrier", "American Shorthair", "Rottweiler", "Exotic Shorthair", "Doberman", "Angorá Turco", "Malamute do Alasca", "Cornish Rex", "Buldogue Inglês", "Balinês", "Pinscher Miniatura", "Havana Brown", "Maltês", "Burmês", "Akita Inu", "Tonquinês", "Bichon Frisé", "Manx", "Lhasa Apso", "Somali", "Basenji", "Ocicat", "Shar Pei", "Snowshoe", "Boston Terrier", "Singapura", "Setter Irlandês", "Peterbald", "Weimaraner", "Cymric", "Cão de Crista Chinês", "Munchkin", "Fox Terrier", "LaPerm", "Samoieda", "Selkirk Rex", "Schnauzer Miniatura", "American Curl", "Whippet", "Turkish Van", "Pekingese", "Japanese Bobtail", "Cão de Água Português", "Nebelung", "Cairn Terrier", "Ragamuffin", "Galgo Afegão", "Oriental Longhair", "Bloodhound", "Bombay", "Setter Inglês", "Javanês", "Bullmastiff", "Thai", "Cão de São Bernardo", "Chausie", "Buldogue Americano", "Khao Manee", "Borzoi", "Cão Esquimó Americano", "Skye Terrier", "Devon Rex", "Schipperke", "Toyger", "Leonberger", "Lykoi", "Cão de Montanha dos Pirineus", "Singapura", "Cão de Caça Afegão", "Pixie-Bob", "Terrier Tibetano", "Exotic Longhair" });
            boxRaca.Location = new Point(373, 295);
            boxRaca.Name = "boxRaca";
            boxRaca.Size = new Size(116, 23);
            boxRaca.TabIndex = 6;
            // 
            // comboEspecie
            // 
            comboEspecie.FlatStyle = FlatStyle.Flat;
            comboEspecie.FormattingEnabled = true;
            comboEspecie.Items.AddRange(new object[] { "Leão  ", "Tigre  ", "Elefante  ", "Girafa  ", "Zebra  ", "Rinoceronte  ", "Hipopótamo  ", "Urso-pardo  ", "Urso-polar  ", "Lobo  ", "Raposa  ", "Cervo  ", "Veado  ", "Anta  ", "Bicho-preguiça  ", "Tamanduá-bandeira  ", "Capivara  ", "Onça-pintada  ", "Puma  ", "Gato-doméstico  ", "Cachorro-doméstico  ", "Coelho  ", "Lebre  ", "Cavalo  ", "Pônei  ", "Burro  ", "Jumento  ", "Vaca  ", "Boi  ", "Touro  ", "Ovelha  ", "Cabra  ", "Porco  ", "Galinha  ", "Galo  ", "Pato  ", "Ganso  ", "Peru  ", "Avestruz  ", "Ema  ", "Tatu  ", "Armadilho  ", "Jacaré  ", "Crocodilo  ", "Camaleão  ", "Lagarto  ", "Iguana  ", "Cobra  ", "Jararaca  ", "Sucuri  ", "Coral  ", "Peixe-palhaço  ", "Tubarão-branco  ", "Orca  ", "Golfinho  ", "Baleia-azul  ", "Foca  ", "Leão-marinho  ", "Morsa  ", "Pinguim  ", "Pelicano  ", "Garça  ", "Coruja  ", "Falcão  ", "Águia  ", "Gavião  ", "Papagaio  ", "Arara  ", "Canário  ", "Pardal  ", "Andorinha  ", "Beija-flor  ", "Morcego  ", "Esquilo  ", "Castor  ", "Lontra  ", "Rato  ", "Ratazana  ", "Camundongo  ", "Hamster  ", "Porquinho-da-índia  ", "Chinchila  ", "Macaco-prego  ", "Bugio  ", "Gorila  ", "Chimpanzé  ", "Orangotango  ", "Lêmure  ", "Suricata  ", "Canguru  ", "Coala  ", "Diabo-da-tasmânia  ", "Formiga  ", "Abelha  ", "Vespa  ", "Borboleta  ", "Mariposa  ", "Besouro  ", "Joaninha  ", "Grilo  ", "Gafanhoto  ", "Libélula  ", "Caracol  ", "Lesma  " });
            comboEspecie.Location = new Point(641, 250);
            comboEspecie.Name = "comboEspecie";
            comboEspecie.Size = new Size(409, 23);
            comboEspecie.TabIndex = 4;
            // 
            // txtPelagem
            // 
            txtPelagem.BorderStyle = BorderStyle.None;
            txtPelagem.Font = new Font("Segoe UI", 13F);
            txtPelagem.Location = new Point(228, 250);
            txtPelagem.Name = "txtPelagem";
            txtPelagem.Size = new Size(270, 24);
            txtPelagem.TabIndex = 3;
            // 
            // boxSexo
            // 
            boxSexo.FlatStyle = FlatStyle.Flat;
            boxSexo.FormattingEnabled = true;
            boxSexo.Items.AddRange(new object[] { "macho", "femea" });
            boxSexo.Location = new Point(641, 295);
            boxSexo.Name = "boxSexo";
            boxSexo.Size = new Size(136, 23);
            boxSexo.TabIndex = 7;
            boxSexo.SelectedIndexChanged += boxSexo_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 241, 201);
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.InitialImage = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.Location = new Point(47, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1099, 556);
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 241, 201);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(339, 396);
            button1.Name = "button1";
            button1.Size = new Size(438, 95);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 241, 201);
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(797, 291);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 37;
            label9.Text = "Peso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 241, 201);
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(797, 205);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 49;
            label4.Text = "CPF Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 241, 201);
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(547, 205);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 31;
            label6.Text = "RG Animal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 241, 201);
            label12.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(548, 250);
            label12.Name = "label12";
            label12.Size = new Size(75, 23);
            label12.TabIndex = 43;
            label12.Text = "Especie:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(255, 241, 201);
            label13.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(548, 295);
            label13.Name = "label13";
            label13.Size = new Size(53, 23);
            label13.TabIndex = 46;
            label13.Text = "Sexo:";
            label13.Click += label13_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 241, 201);
            label11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(316, 295);
            label11.Name = "label11";
            label11.Size = new Size(53, 23);
            label11.TabIndex = 41;
            label11.Text = "Raça:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 241, 201);
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(145, 295);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 26;
            label3.Text = "Idade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 241, 201);
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(145, 250);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 53;
            label5.Text = "Pelagem: ";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 241, 201);
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(145, 205);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 23;
            label2.Text = "Nome:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // Servico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 228, 178);
            ClientSize = new Size(1147, 580);
            Controls.Add(txtPelagem);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(boxSexo);
            Controls.Add(comboEspecie);
            Controls.Add(boxRaca);
            Controls.Add(txtcpfcliente);
            Controls.Add(label4);
            Controls.Add(txtrganimal);
            Controls.Add(txtIdade);
            Controls.Add(txt_Peso);
            Controls.Add(txtnomepet);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Servico";
            Text = "Servico";
            Load += Servico_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox txtrganimal;
        private TextBox txt_Peso;
        private TextBox txtnomepet;
        private Label label1;
        private TextBox txtIdade;
        private MaskedTextBox txtcpfcliente;
        private ComboBox boxRaca;
        private ComboBox comboEspecie;
        private TextBox txtPelagem;
        private ComboBox boxSexo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label9;
        private Label label4;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label3;
        private Label label5;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
