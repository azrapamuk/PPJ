namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDownBrisanjeStavke = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIDArtiklaBrisanje = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPregledArtikala = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalKorpa = new System.Windows.Forms.TextBox();
            this.textBoxIDArtikla = new System.Windows.Forms.TextBox();
            this.buttonObrisiKorpa = new System.Windows.Forms.Button();
            this.buttonDodajKorpa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKorpa = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonPrikazStavkiNarudzbe = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTotalNarudzba = new System.Windows.Forms.TextBox();
            this.textBoxIDNarudzbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewStavke = new System.Windows.Forms.DataGridView();
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrisanjeStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorpa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg2;
            this.tabPage1.Controls.Add(this.numericUpDownBrisanjeStavke);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBoxIDArtiklaBrisanje);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridViewPregledArtikala);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxTotalKorpa);
            this.tabPage1.Controls.Add(this.textBoxIDArtikla);
            this.tabPage1.Controls.Add(this.buttonObrisiKorpa);
            this.tabPage1.Controls.Add(this.buttonDodajKorpa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewKorpa);
            this.tabPage1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kreiranje narudžbe";
            // 
            // numericUpDownBrisanjeStavke
            // 
            this.numericUpDownBrisanjeStavke.Location = new System.Drawing.Point(702, 232);
            this.numericUpDownBrisanjeStavke.Name = "numericUpDownBrisanjeStavke";
            this.numericUpDownBrisanjeStavke.Size = new System.Drawing.Size(66, 19);
            this.numericUpDownBrisanjeStavke.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(619, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "Količina:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(619, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "ID:";
            // 
            // textBoxIDArtiklaBrisanje
            // 
            this.textBoxIDArtiklaBrisanje.Location = new System.Drawing.Point(654, 210);
            this.textBoxIDArtiklaBrisanje.Name = "textBoxIDArtiklaBrisanje";
            this.textBoxIDArtiklaBrisanje.Size = new System.Drawing.Size(114, 19);
            this.textBoxIDArtiklaBrisanje.TabIndex = 31;
            this.textBoxIDArtiklaBrisanje.TextChanged += new System.EventHandler(this.textBoxIDArtiklaBrisanje_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(475, 229);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 19);
            this.numericUpDown1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(632, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Dodaj narudžbu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPregledArtikala
            // 
            this.dataGridViewPregledArtikala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPregledArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledArtikala.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewPregledArtikala.Name = "dataGridViewPregledArtikala";
            this.dataGridViewPregledArtikala.Size = new System.Drawing.Size(380, 289);
            this.dataGridViewPregledArtikala.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(586, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(392, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(392, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "Količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(392, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID:";
            // 
            // textBoxTotalKorpa
            // 
            this.textBoxTotalKorpa.Location = new System.Drawing.Point(451, 298);
            this.textBoxTotalKorpa.Name = "textBoxTotalKorpa";
            this.textBoxTotalKorpa.Size = new System.Drawing.Size(129, 19);
            this.textBoxTotalKorpa.TabIndex = 23;
            // 
            // textBoxIDArtikla
            // 
            this.textBoxIDArtikla.Location = new System.Drawing.Point(427, 207);
            this.textBoxIDArtikla.Name = "textBoxIDArtikla";
            this.textBoxIDArtikla.Size = new System.Drawing.Size(114, 19);
            this.textBoxIDArtikla.TabIndex = 21;
            this.textBoxIDArtikla.TextChanged += new System.EventHandler(this.textBoxIDArtikla_TextChanged);
            // 
            // buttonObrisiKorpa
            // 
            this.buttonObrisiKorpa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonObrisiKorpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrisiKorpa.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiKorpa.ForeColor = System.Drawing.Color.White;
            this.buttonObrisiKorpa.Location = new System.Drawing.Point(664, 257);
            this.buttonObrisiKorpa.Name = "buttonObrisiKorpa";
            this.buttonObrisiKorpa.Size = new System.Drawing.Size(74, 23);
            this.buttonObrisiKorpa.TabIndex = 20;
            this.buttonObrisiKorpa.Text = "Obriši";
            this.buttonObrisiKorpa.UseVisualStyleBackColor = false;
            this.buttonObrisiKorpa.Click += new System.EventHandler(this.buttonObrisiKorpa_Click);
            // 
            // buttonDodajKorpa
            // 
            this.buttonDodajKorpa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonDodajKorpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajKorpa.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajKorpa.ForeColor = System.Drawing.Color.White;
            this.buttonDodajKorpa.Location = new System.Drawing.Point(436, 254);
            this.buttonDodajKorpa.Name = "buttonDodajKorpa";
            this.buttonDodajKorpa.Size = new System.Drawing.Size(74, 23);
            this.buttonDodajKorpa.TabIndex = 19;
            this.buttonDodajKorpa.Text = "Dodaj";
            this.buttonDodajKorpa.UseVisualStyleBackColor = false;
            this.buttonDodajKorpa.Click += new System.EventHandler(this.buttonDodajKorpa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(392, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korpa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregled artikala";
            // 
            // dataGridViewKorpa
            // 
            this.dataGridViewKorpa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKorpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorpa.Location = new System.Drawing.Point(394, 34);
            this.dataGridViewKorpa.Name = "dataGridViewKorpa";
            this.dataGridViewKorpa.Size = new System.Drawing.Size(374, 170);
            this.dataGridViewKorpa.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.buttonPrikazStavkiNarudzbe);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxTotalNarudzba);
            this.tabPage2.Controls.Add(this.textBoxIDNarudzbe);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataGridViewStavke);
            this.tabPage2.Controls.Add(this.dataGridViewNarudzbe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prikaz narudžbi i stavki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonPrikazStavkiNarudzbe
            // 
            this.buttonPrikazStavkiNarudzbe.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPrikazStavkiNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrikazStavkiNarudzbe.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazStavkiNarudzbe.ForeColor = System.Drawing.Color.White;
            this.buttonPrikazStavkiNarudzbe.Location = new System.Drawing.Point(408, 313);
            this.buttonPrikazStavkiNarudzbe.Name = "buttonPrikazStavkiNarudzbe";
            this.buttonPrikazStavkiNarudzbe.Size = new System.Drawing.Size(130, 21);
            this.buttonPrikazStavkiNarudzbe.TabIndex = 9;
            this.buttonPrikazStavkiNarudzbe.Text = "Prikaz stavki";
            this.buttonPrikazStavkiNarudzbe.UseVisualStyleBackColor = false;
            this.buttonPrikazStavkiNarudzbe.Click += new System.EventHandler(this.buttonPrikazStavkiNarudzbe_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(381, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "KM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(239, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID narudžbe:";
            // 
            // textBoxTotalNarudzba
            // 
            this.textBoxTotalNarudzba.Location = new System.Drawing.Point(292, 315);
            this.textBoxTotalNarudzba.Name = "textBoxTotalNarudzba";
            this.textBoxTotalNarudzba.Size = new System.Drawing.Size(83, 19);
            this.textBoxTotalNarudzba.TabIndex = 5;
            // 
            // textBoxIDNarudzbe
            // 
            this.textBoxIDNarudzbe.Location = new System.Drawing.Point(113, 313);
            this.textBoxIDNarudzbe.Name = "textBoxIDNarudzbe";
            this.textBoxIDNarudzbe.Size = new System.Drawing.Size(100, 19);
            this.textBoxIDNarudzbe.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(406, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Stavke narudžbe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Narudžbe";
            // 
            // dataGridViewStavke
            // 
            this.dataGridViewStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStavke.Location = new System.Drawing.Point(408, 27);
            this.dataGridViewStavke.Name = "dataGridViewStavke";
            this.dataGridViewStavke.Size = new System.Drawing.Size(360, 280);
            this.dataGridViewStavke.TabIndex = 1;
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(8, 27);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(392, 282);
            this.dataGridViewNarudzbe.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed_1);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrisanjeStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorpa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKorpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalKorpa;
        private System.Windows.Forms.TextBox textBoxIDArtikla;
        private System.Windows.Forms.Button buttonObrisiKorpa;
        private System.Windows.Forms.Button buttonDodajKorpa;
        private System.Windows.Forms.Button buttonPrikazStavkiNarudzbe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTotalNarudzba;
        private System.Windows.Forms.TextBox textBoxIDNarudzbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewStavke;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.DataGridView dataGridViewPregledArtikala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDownBrisanjeStavke;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIDArtiklaBrisanje;
    }
}