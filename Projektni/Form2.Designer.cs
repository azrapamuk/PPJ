namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAzurirajKupca = new System.Windows.Forms.Button();
            this.buttonKreirajKupca = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDKupacAzuriraj = new System.Windows.Forms.TextBox();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeTrazi = new System.Windows.Forms.TextBox();
            this.textBoxTraziIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlAdministrator = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownKolicina = new System.Windows.Forms.NumericUpDown();
            this.buttonAzurirajArtikal = new System.Windows.Forms.Button();
            this.buttonDodajArtikal = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxIDartikla = new System.Windows.Forms.TextBox();
            this.textBoxKolicinaArtikala = new System.Windows.Forms.TextBox();
            this.textBoxCijenaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxVrstaArtikla = new System.Windows.Forms.TextBox();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.textBoxNazivTrazi = new System.Windows.Forms.TextBox();
            this.textBoxSifraTrazi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNarudzba = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlAdministrator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            tabPage1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg1;
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage1.Controls.Add(this.buttonAzurirajKupca);
            tabPage1.Controls.Add(this.buttonKreirajKupca);
            tabPage1.Controls.Add(this.label8);
            tabPage1.Controls.Add(this.textBoxIDKupacAzuriraj);
            tabPage1.Controls.Add(this.textBoxKorIme);
            tabPage1.Controls.Add(this.textBoxSifra);
            tabPage1.Controls.Add(this.textBoxTelefon);
            tabPage1.Controls.Add(this.textBoxAdresa);
            tabPage1.Controls.Add(this.textBoxPrezime);
            tabPage1.Controls.Add(this.textBoxGrad);
            tabPage1.Controls.Add(this.textBoxIme);
            tabPage1.Controls.Add(this.textBoxPrezimeTrazi);
            tabPage1.Controls.Add(this.textBoxTraziIme);
            tabPage1.Controls.Add(this.label7);
            tabPage1.Controls.Add(this.label6);
            tabPage1.Controls.Add(this.label5);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.label3);
            tabPage1.Controls.Add(this.label2);
            tabPage1.Controls.Add(this.label1);
            tabPage1.Controls.Add(this.dataGridView1);
            tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(792, 354);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kreiranje/ažuriranje kupca";
            // 
            // buttonAzurirajKupca
            // 
            this.buttonAzurirajKupca.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAzurirajKupca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAzurirajKupca.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAzurirajKupca.ForeColor = System.Drawing.Color.White;
            this.buttonAzurirajKupca.Location = new System.Drawing.Point(588, 295);
            this.buttonAzurirajKupca.Name = "buttonAzurirajKupca";
            this.buttonAzurirajKupca.Size = new System.Drawing.Size(127, 23);
            this.buttonAzurirajKupca.TabIndex = 19;
            this.buttonAzurirajKupca.Text = "Ažuriraj kupca";
            this.buttonAzurirajKupca.UseVisualStyleBackColor = false;
            this.buttonAzurirajKupca.Click += new System.EventHandler(this.buttonAzurirajKupca_Click);
            // 
            // buttonKreirajKupca
            // 
            this.buttonKreirajKupca.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonKreirajKupca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKreirajKupca.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKreirajKupca.ForeColor = System.Drawing.Color.White;
            this.buttonKreirajKupca.Location = new System.Drawing.Point(277, 312);
            this.buttonKreirajKupca.Name = "buttonKreirajKupca";
            this.buttonKreirajKupca.Size = new System.Drawing.Size(125, 23);
            this.buttonKreirajKupca.TabIndex = 18;
            this.buttonKreirajKupca.Text = "Kreiraj kupca";
            this.buttonKreirajKupca.UseVisualStyleBackColor = false;
            this.buttonKreirajKupca.Click += new System.EventHandler(this.buttonKreirajKupca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(463, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID kupca:";
            // 
            // textBoxIDKupacAzuriraj
            // 
            this.textBoxIDKupacAzuriraj.Location = new System.Drawing.Point(534, 296);
            this.textBoxIDKupacAzuriraj.Name = "textBoxIDKupacAzuriraj";
            this.textBoxIDKupacAzuriraj.Size = new System.Drawing.Size(48, 19);
            this.textBoxIDKupacAzuriraj.TabIndex = 16;
            this.textBoxIDKupacAzuriraj.TextChanged += new System.EventHandler(this.textBoxIDKupacAzuriraj_TextChanged);
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Location = new System.Drawing.Point(302, 255);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(100, 19);
            this.textBoxKorIme.TabIndex = 8;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(302, 283);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 19);
            this.textBoxSifra.TabIndex = 8;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(302, 223);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 19);
            this.textBoxTelefon.TabIndex = 7;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(89, 311);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(100, 19);
            this.textBoxAdresa.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(89, 255);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 19);
            this.textBoxPrezime.TabIndex = 5;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(89, 286);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(100, 19);
            this.textBoxGrad.TabIndex = 5;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(89, 223);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 19);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxPrezimeTrazi
            // 
            this.textBoxPrezimeTrazi.Location = new System.Drawing.Point(231, 6);
            this.textBoxPrezimeTrazi.Name = "textBoxPrezimeTrazi";
            this.textBoxPrezimeTrazi.Size = new System.Drawing.Size(85, 19);
            this.textBoxPrezimeTrazi.TabIndex = 1;
            this.textBoxPrezimeTrazi.TextChanged += new System.EventHandler(this.textBoxPrezimeTrazi_TextChanged);
            // 
            // textBoxTraziIme
            // 
            this.textBoxTraziIme.Location = new System.Drawing.Point(131, 6);
            this.textBoxTraziIme.Name = "textBoxTraziIme";
            this.textBoxTraziIme.Size = new System.Drawing.Size(85, 19);
            this.textBoxTraziIme.TabIndex = 0;
            this.textBoxTraziIme.TextChanged += new System.EventHandler(this.textBoxTraziIme_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(253, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Šifra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(189, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(239, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(41, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Grad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 180);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabControlAdministrator
            // 
            this.tabControlAdministrator.Controls.Add(tabPage1);
            this.tabControlAdministrator.Controls.Add(this.tabPage2);
            this.tabControlAdministrator.Controls.Add(this.tabPage3);
            this.tabControlAdministrator.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdministrator.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdministrator.Name = "tabControlAdministrator";
            this.tabControlAdministrator.SelectedIndex = 0;
            this.tabControlAdministrator.Size = new System.Drawing.Size(800, 380);
            this.tabControlAdministrator.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.numericUpDownKolicina);
            this.tabPage2.Controls.Add(this.buttonAzurirajArtikal);
            this.tabPage2.Controls.Add(this.buttonDodajArtikal);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBoxIDartikla);
            this.tabPage2.Controls.Add(this.textBoxKolicinaArtikala);
            this.tabPage2.Controls.Add(this.textBoxCijenaArtikla);
            this.tabPage2.Controls.Add(this.textBoxVrstaArtikla);
            this.tabPage2.Controls.Add(this.textBoxNazivArtikla);
            this.tabPage2.Controls.Add(this.textBoxNazivTrazi);
            this.tabPage2.Controls.Add(this.textBoxSifraTrazi);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodavanje/ažuriranje artikla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(557, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "Dodaj količinu:";
            // 
            // numericUpDownKolicina
            // 
            this.numericUpDownKolicina.Location = new System.Drawing.Point(673, 262);
            this.numericUpDownKolicina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownKolicina.Name = "numericUpDownKolicina";
            this.numericUpDownKolicina.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownKolicina.TabIndex = 42;
            // 
            // buttonAzurirajArtikal
            // 
            this.buttonAzurirajArtikal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAzurirajArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAzurirajArtikal.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAzurirajArtikal.ForeColor = System.Drawing.Color.White;
            this.buttonAzurirajArtikal.Location = new System.Drawing.Point(571, 312);
            this.buttonAzurirajArtikal.Name = "buttonAzurirajArtikal";
            this.buttonAzurirajArtikal.Size = new System.Drawing.Size(150, 23);
            this.buttonAzurirajArtikal.TabIndex = 41;
            this.buttonAzurirajArtikal.Text = "Ažuriraj artikal";
            this.buttonAzurirajArtikal.UseVisualStyleBackColor = false;
            this.buttonAzurirajArtikal.Click += new System.EventHandler(this.buttonAzurirajArtikal_Click);
            // 
            // buttonDodajArtikal
            // 
            this.buttonDodajArtikal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonDodajArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajArtikal.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajArtikal.ForeColor = System.Drawing.Color.White;
            this.buttonDodajArtikal.Location = new System.Drawing.Point(282, 312);
            this.buttonDodajArtikal.Name = "buttonDodajArtikal";
            this.buttonDodajArtikal.Size = new System.Drawing.Size(126, 23);
            this.buttonDodajArtikal.TabIndex = 40;
            this.buttonDodajArtikal.Text = "Dodaj artikal";
            this.buttonDodajArtikal.UseVisualStyleBackColor = false;
            this.buttonDodajArtikal.Click += new System.EventHandler(this.buttonDodajArtikal_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(585, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 12);
            this.label17.TabIndex = 39;
            this.label17.Text = "ID artikla:";
            // 
            // textBoxIDartikla
            // 
            this.textBoxIDartikla.Location = new System.Drawing.Point(673, 229);
            this.textBoxIDartikla.Name = "textBoxIDartikla";
            this.textBoxIDartikla.Size = new System.Drawing.Size(48, 19);
            this.textBoxIDartikla.TabIndex = 38;
            this.textBoxIDartikla.TextChanged += new System.EventHandler(this.textBoxIDartikla_TextChanged);
            // 
            // textBoxKolicinaArtikala
            // 
            this.textBoxKolicinaArtikala.Location = new System.Drawing.Point(308, 261);
            this.textBoxKolicinaArtikala.Name = "textBoxKolicinaArtikala";
            this.textBoxKolicinaArtikala.Size = new System.Drawing.Size(100, 19);
            this.textBoxKolicinaArtikala.TabIndex = 30;
            // 
            // textBoxCijenaArtikla
            // 
            this.textBoxCijenaArtikla.Location = new System.Drawing.Point(308, 229);
            this.textBoxCijenaArtikla.Name = "textBoxCijenaArtikla";
            this.textBoxCijenaArtikla.Size = new System.Drawing.Size(100, 19);
            this.textBoxCijenaArtikla.TabIndex = 28;
            // 
            // textBoxVrstaArtikla
            // 
            this.textBoxVrstaArtikla.Location = new System.Drawing.Point(108, 261);
            this.textBoxVrstaArtikla.Name = "textBoxVrstaArtikla";
            this.textBoxVrstaArtikla.Size = new System.Drawing.Size(100, 19);
            this.textBoxVrstaArtikla.TabIndex = 26;
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(108, 229);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(100, 19);
            this.textBoxNazivArtikla.TabIndex = 24;
            // 
            // textBoxNazivTrazi
            // 
            this.textBoxNazivTrazi.Location = new System.Drawing.Point(168, 6);
            this.textBoxNazivTrazi.Name = "textBoxNazivTrazi";
            this.textBoxNazivTrazi.Size = new System.Drawing.Size(113, 19);
            this.textBoxNazivTrazi.TabIndex = 21;
            this.textBoxNazivTrazi.TextChanged += new System.EventHandler(this.textBoxNazivTrazi_TextChanged);
            // 
            // textBoxSifraTrazi
            // 
            this.textBoxSifraTrazi.Location = new System.Drawing.Point(108, 6);
            this.textBoxSifraTrazi.Name = "textBoxSifraTrazi";
            this.textBoxSifraTrazi.Size = new System.Drawing.Size(54, 19);
            this.textBoxSifraTrazi.TabIndex = 20;
            this.textBoxSifraTrazi.TextChanged += new System.EventHandler(this.textBoxSifraTrazi_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(234, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 12);
            this.label19.TabIndex = 36;
            this.label19.Text = "Količina:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(248, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 12);
            this.label20.TabIndex = 35;
            this.label20.Text = "Cijena:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(6, 264);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 12);
            this.label23.TabIndex = 32;
            this.label23.Text = "Vrsta artikla:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(3, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 12);
            this.label24.TabIndex = 31;
            this.label24.Text = "Naziv artikla:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(29, 34);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(727, 179);
            this.dataGridView3.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg1;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBoxNarudzba);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Prikaz/Brisanje narudžbe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(624, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Brisanje narudžbe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNarudzba
            // 
            this.textBoxNarudzba.Location = new System.Drawing.Point(541, 313);
            this.textBoxNarudzba.Name = "textBoxNarudzba";
            this.textBoxNarudzba.Size = new System.Drawing.Size(77, 19);
            this.textBoxNarudzba.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID narudžbe:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(770, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 371);
            this.Controls.Add(this.tabControlAdministrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlAdministrator.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAzurirajArtikal;
        private System.Windows.Forms.Button buttonDodajArtikal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxIDartikla;
        private System.Windows.Forms.TextBox textBoxKolicinaArtikala;
        private System.Windows.Forms.TextBox textBoxCijenaArtikla;
        private System.Windows.Forms.TextBox textBoxVrstaArtikla;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.TextBox textBoxNazivTrazi;
        private System.Windows.Forms.TextBox textBoxSifraTrazi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonAzurirajKupca;
        private System.Windows.Forms.Button buttonKreirajKupca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIDKupacAzuriraj;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezimeTrazi;
        private System.Windows.Forms.TextBox textBoxTraziIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlAdministrator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownKolicina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNarudzba;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}