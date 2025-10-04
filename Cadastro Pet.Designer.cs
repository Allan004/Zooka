namespace Zooka
{
    partial class Cadastro_Pet
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
            button1 = new Button();
            txtrganimal = new MaskedTextBox();
            txt_Peso = new TextBox();
            txtnomepet = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label12 = new Label();
            txtIdade = new TextBox();
            label4 = new Label();
            txtcpfcliente = new MaskedTextBox();
            boxRaca = new ComboBox();
            comboEspecie = new ComboBox();
            label5 = new Label();
            txtPelagem = new TextBox();
            boxSexo = new ComboBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 118, 40);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sans Serif Collection", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(316, 291);
            button1.Name = "button1";
            button1.Size = new Size(191, 71);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtrganimal
            // 
            txtrganimal.Location = new Point(478, 95);
            txtrganimal.Mask = "00.000.000-0";
            txtrganimal.Name = "txtrganimal";
            txtrganimal.Size = new Size(68, 23);
            txtrganimal.TabIndex = 2;
            // 
            // txt_Peso
            // 
            txt_Peso.Location = new Point(639, 173);
            txt_Peso.Name = "txt_Peso";
            txt_Peso.Size = new Size(91, 23);
            txt_Peso.TabIndex = 8;
            // 
            // txtnomepet
            // 
            txtnomepet.Location = new Point(125, 100);
            txtnomepet.Name = "txtnomepet";
            txtnomepet.Size = new Size(270, 23);
            txtnomepet.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sans Serif Collection", 8.999999F);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(405, 168);
            label13.Name = "label13";
            label13.Size = new Size(48, 41);
            label13.TabIndex = 46;
            label13.Text = "Sexo:";
            label13.Click += label13_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sans Serif Collection", 8.999999F);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(204, 168);
            label11.Name = "label11";
            label11.Size = new Size(48, 41);
            label11.TabIndex = 41;
            label11.Text = "Raça:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sans Serif Collection", 8.999999F);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(597, 168);
            label9.Name = "label9";
            label9.Size = new Size(48, 41);
            label9.TabIndex = 37;
            label9.Text = "Peso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 8.999999F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(404, 90);
            label6.Name = "label6";
            label6.Size = new Size(78, 41);
            label6.TabIndex = 31;
            label6.Text = "RG Animal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 8.999999F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(64, 95);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 23;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(316, 36);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO PET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 8.999999F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(65, 168);
            label3.Name = "label3";
            label3.Size = new Size(50, 41);
            label3.TabIndex = 26;
            label3.Text = "Idade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sans Serif Collection", 8.999999F);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(405, 129);
            label12.Name = "label12";
            label12.Size = new Size(64, 41);
            label12.TabIndex = 43;
            label12.Text = "Especie:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(125, 173);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(73, 23);
            txtIdade.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(552, 90);
            label4.Name = "label4";
            label4.Size = new Size(83, 41);
            label4.TabIndex = 49;
            label4.Text = "CPF Cliente:";
            // 
            // txtcpfcliente
            // 
            txtcpfcliente.Location = new Point(630, 95);
            txtcpfcliente.Mask = "000.000.000-00";
            txtcpfcliente.Name = "txtcpfcliente";
            txtcpfcliente.Size = new Size(100, 23);
            txtcpfcliente.TabIndex = 9;
            // 
            // boxRaca
            // 
            boxRaca.FormattingEnabled = true;
            boxRaca.Items.AddRange(new object[] { "Labrador Retriever", "Siamês", "Golden Retriever", "Persa", "Bulldog Francês", "Maine Coon", "Pastor Alemão", "Ragdoll", "Poodle", "Bengal", "Beagle", "Sphynx", "Shih Tzu", "British Shorthair", "Chihuahua", "Abissínio", "Dachshund", "Birmanês", "Border Collie", "Scottish Fold", "Boxer", "Russian Blue", "Cocker Spaniel", "Savannah", "Husky Siberiano", "Oriental Shorthair", "Pug", "Chartreux", "Yorkshire Terrier", "American Shorthair", "Rottweiler", "Exotic Shorthair", "Doberman", "Angorá Turco", "Malamute do Alasca", "Cornish Rex", "Buldogue Inglês", "Balinês", "Pinscher Miniatura", "Havana Brown", "Maltês", "Burmês", "Akita Inu", "Tonquinês", "Bichon Frisé", "Manx", "Lhasa Apso", "Somali", "Basenji", "Ocicat", "Shar Pei", "Snowshoe", "Boston Terrier", "Singapura", "Setter Irlandês", "Peterbald", "Weimaraner", "Cymric", "Cão de Crista Chinês", "Munchkin", "Fox Terrier", "LaPerm", "Samoieda", "Selkirk Rex", "Schnauzer Miniatura", "American Curl", "Whippet", "Turkish Van", "Pekingese", "Japanese Bobtail", "Cão de Água Português", "Nebelung", "Cairn Terrier", "Ragamuffin", "Galgo Afegão", "Oriental Longhair", "Bloodhound", "Bombay", "Setter Inglês", "Javanês", "Bullmastiff", "Thai", "Cão de São Bernardo", "Chausie", "Buldogue Americano", "Khao Manee", "Borzoi", "Cão Esquimó Americano", "Skye Terrier", "Devon Rex", "Schipperke", "Toyger", "Leonberger", "Lykoi", "Cão de Montanha dos Pirineus", "Singapura", "Cão de Caça Afegão", "Pixie-Bob", "Terrier Tibetano", "Exotic Longhair" });
            boxRaca.Location = new Point(247, 173);
            boxRaca.Name = "boxRaca";
            boxRaca.Size = new Size(152, 23);
            boxRaca.TabIndex = 6;
            // 
            // comboEspecie
            // 
            comboEspecie.FormattingEnabled = true;
            comboEspecie.Items.AddRange(new object[] { "Leão  ", "Tigre  ", "Elefante  ", "Girafa  ", "Zebra  ", "Rinoceronte  ", "Hipopótamo  ", "Urso-pardo  ", "Urso-polar  ", "Lobo  ", "Raposa  ", "Cervo  ", "Veado  ", "Anta  ", "Bicho-preguiça  ", "Tamanduá-bandeira  ", "Capivara  ", "Onça-pintada  ", "Puma  ", "Gato-doméstico  ", "Cachorro-doméstico  ", "Coelho  ", "Lebre  ", "Cavalo  ", "Pônei  ", "Burro  ", "Jumento  ", "Vaca  ", "Boi  ", "Touro  ", "Ovelha  ", "Cabra  ", "Porco  ", "Galinha  ", "Galo  ", "Pato  ", "Ganso  ", "Peru  ", "Avestruz  ", "Ema  ", "Tatu  ", "Armadilho  ", "Jacaré  ", "Crocodilo  ", "Camaleão  ", "Lagarto  ", "Iguana  ", "Cobra  ", "Jararaca  ", "Sucuri  ", "Coral  ", "Peixe-palhaço  ", "Tubarão-branco  ", "Orca  ", "Golfinho  ", "Baleia-azul  ", "Foca  ", "Leão-marinho  ", "Morsa  ", "Pinguim  ", "Pelicano  ", "Garça  ", "Coruja  ", "Falcão  ", "Águia  ", "Gavião  ", "Papagaio  ", "Arara  ", "Canário  ", "Pardal  ", "Andorinha  ", "Beija-flor  ", "Morcego  ", "Esquilo  ", "Castor  ", "Lontra  ", "Rato  ", "Ratazana  ", "Camundongo  ", "Hamster  ", "Porquinho-da-índia  ", "Chinchila  ", "Macaco-prego  ", "Bugio  ", "Gorila  ", "Chimpanzé  ", "Orangotango  ", "Lêmure  ", "Suricata  ", "Canguru  ", "Coala  ", "Diabo-da-tasmânia  ", "Formiga  ", "Abelha  ", "Vespa  ", "Borboleta  ", "Mariposa  ", "Besouro  ", "Joaninha  ", "Grilo  ", "Gafanhoto  ", "Libélula  ", "Caracol  ", "Lesma  " });
            comboEspecie.Location = new Point(478, 134);
            comboEspecie.Name = "comboEspecie";
            comboEspecie.Size = new Size(252, 23);
            comboEspecie.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(64, 129);
            label5.Name = "label5";
            label5.Size = new Size(72, 41);
            label5.TabIndex = 53;
            label5.Text = "Pelagem: ";
            label5.Click += label5_Click;
            // 
            // txtPelagem
            // 
            txtPelagem.Location = new Point(125, 134);
            txtPelagem.Name = "txtPelagem";
            txtPelagem.Size = new Size(270, 23);
            txtPelagem.TabIndex = 3;
            // 
            // boxSexo
            // 
            boxSexo.FormattingEnabled = true;
            boxSexo.Items.AddRange(new object[] { "macho", "femea" });
            boxSexo.Location = new Point(478, 173);
            boxSexo.Name = "boxSexo";
            boxSexo.Size = new Size(98, 23);
            boxSexo.TabIndex = 7;
            boxSexo.SelectedIndexChanged += boxSexo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(255, 118, 40);
            label7.Location = new Point(0, 258);
            label7.Name = "label7";
            label7.Size = new Size(804, 131);
            label7.TabIndex = 54;
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.InitialImage = Properties.Resources.Captura_de_tela_2025_09_26_191727_removebg_preview;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // Cadastro_Pet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(88, 120, 248);
            ClientSize = new Size(800, 388);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(boxSexo);
            Controls.Add(txtPelagem);
            Controls.Add(label5);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_Pet";
            Text = "Cadastro_Pet";
            Load += Cadastro_Pet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtrganimal;
        private TextBox txt_Peso;
        private TextBox txtnomepet;
        private Label label13;
        private Label label11;
        private Label label9;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label12;
        private TextBox txtIdade;
        private Label label4;
        private MaskedTextBox txtcpfcliente;
        private ComboBox boxRaca;
        private ComboBox comboEspecie;
        private Label label5;
        private TextBox txtPelagem;
        private ComboBox boxSexo;
        private Label label7;
        private PictureBox pictureBox1;
    }   
}