using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.dataGridViewPregledArtikala.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewPregledArtikala.DefaultCellStyle.Font = new Font("Lucida Console", 7);
            this.dataGridViewKorpa.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewKorpa.DefaultCellStyle.Font = new Font("Lucida Console", 7);
        }
        
        String konekcionistring = Form1.konekcionistr;

        String kupacID=Form1.kupacID;

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            VracanjeDodanihArtikala();
            BrisanjeNarudzbe();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            string poruka = "Da li ste sigurni da želite zatvoriti ovu stranicu i odjaviti se?";
            string opis = "";
            var result = MessageBox.Show(poruka, opis, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String upit = "SELECT a.artikal_id AS ID,a.naziv_artikla AS Naziv,"+
                "a.vrsta_artikla as Vrsta, cijena as Cijena, s.količina_stanje as 'Količina na stanju'  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
            PrikazArtikala(upit);
            PrikazNarudzbi();
            novanarudzba = 0;
        }

        private void PrikazArtikala(string upit)
        {

            try
            {
             
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridViewPregledArtikala.DataSource = tabela;

                data.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    ///
    /// PRIKAZ NARUDŽBI
    /// 

        private void PrikazNarudzbi()
        {
            try
            {
                string id = Form1.kupacID;
                String upit = "SELECT narudžbenica_id AS 'ID narudžbe',datum_narudžbe as 'Datum narudžbe' FROM narudžbenica WHERE kupac_id="+kupacID;

                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridViewNarudzbe.DataSource = tabela;

                data.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    //STAVKE NARUDŽBE

        private void buttonPrikazStavkiNarudzbe_Click(object sender, EventArgs e)
        {
            textBoxTotalNarudzba.Text = "";
            errorProvider1.Clear();
            if (textBoxIDNarudzbe.Text == "") errorProvider1.SetError(textBoxIDNarudzbe, "Obavezno!");
            else
            {
                try
                {
                    double total = 0;
                    string idnaruzbe=textBoxIDNarudzbe.Text;
                    String upit = "SELECT a.naziv_artikla as 'Naziv artikla',a.cijena as 'Cijena',s.količina as 'Količina' FROM stavka_narudžbenice s, artikal a,narudžbenica n WHERE s.narudžbenica_id=" + idnaruzbe+
                                   " AND a.artikal_id=s.artikal_id AND n.narudžbenica_id=s.narudžbenica_id AND n.kupac_id="+kupacID;

                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();

                    MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                    DataTable tabela = new DataTable();
                    data.Fill(tabela);

                    dataGridViewStavke.DataSource = tabela;

                    data.Dispose();

                    int redovi = dataGridViewStavke.Rows.Count-1;

                    if (redovi == 0)
                        MessageBox.Show("Narudžba ne postoji!");
                    else
                    {

                        for (int i = 0; i <= redovi; i++)
                        {
                            //ne uzima tacnu cijenu
                            double cijena=Convert.ToDouble(dataGridViewStavke.Rows[i].Cells[1].Value);
                            int kolicina = Convert.ToInt32(dataGridViewStavke.Rows[i].Cells[2].Value);
                            total = total + cijena * kolicina;
                            textBoxTotalNarudzba.Text = total.ToString();
                        }

                    }


                    konekcija.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void textBoxIDArtikla_TextChanged(object sender, EventArgs e)
        {
            string id = textBoxIDArtikla.Text;
            if (id == "")
            {
                numericUpDown1.Value = 0;
                numericUpDown1.Maximum = 0;
            }
            String upit = "SELECT a.artikal_id AS ID,a.naziv_artikla AS Naziv," +
                "a.vrsta_artikla as Vrsta, cijena as Cijena, s.količina_stanje as 'Količina na stanju'  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id AND a.artikal_id LIKE '" + id + "%';";

            PrikazArtikala(upit);

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit,konekcija);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                int maxkolicina = Convert.ToInt32(reader[4]);

                numericUpDown1.Maximum = maxkolicina;

                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    //DODAVANJE ARTIKALA U KORPU

        int novanarudzba;
        int brnarudzbe;

        private void buttonDodajKorpa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxIDArtikla.Text == "") errorProvider1.SetError(textBoxIDArtikla, "Obavezno!");
            else if (numericUpDown1.Value==0) errorProvider1.SetError(numericUpDown1, "Obavezno!");
            else
            {
                try
                {
                    string idartikla = textBoxIDArtikla.Text;
                    int kolicina = Convert.ToInt32(numericUpDown1.Value);
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    if (novanarudzba == 0)
                    {
                        string datum = DateTime.Today.ToString("yyyy/MM/dd");
                        String upit1 = "INSERT INTO narudžbenica(kupac_id,datum_narudžbe) VALUES(" + kupacID + ",'" + datum + "');";
                        MySqlCommand cmd1 = new MySqlCommand(upit1, konekcija);
                        int a = cmd1.ExecuteNonQuery();
                        if (a > 0)
                        {
                            String upit2 = "SELECT MAX(narudžbenica_id) FROM narudžbenica;";
                            MySqlCommand cmd2 = new MySqlCommand(upit2, konekcija);
                            MySqlDataReader reader = cmd2.ExecuteReader();
                            reader.Read();
                            brnarudzbe = Convert.ToInt32(reader[0]);
                            novanarudzba = 1;
                            reader.Close();
                        }
                       
                    }
                    String upit3 = "" ;
                    int provjeraisti=0;
                        for (int i = 0; i < dataGridViewKorpa.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(idartikla) == Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells[1].Value))
                            {
                                int ukupno = kolicina + Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells[4].Value);
                                upit3 = "UPDATE stavka_narudžbenice SET količina=" + ukupno + " WHERE artikal_id=" + idartikla
                                    + " AND narudžbenica_id=" + brnarudzbe;
                                provjeraisti=1;
                            }
                        }
                   if (provjeraisti==0)
                   {
                     upit3 = "INSERT INTO stavka_narudžbenice(narudžbenica_id,artikal_id,količina) " +
                         "VALUES(" + brnarudzbe + "," + idartikla + "," + kolicina + ");";
                    }

                    MySqlCommand cmd3 = new MySqlCommand(upit3, konekcija);
                    int b = cmd3.ExecuteNonQuery();
                    if (b > 0)
                    {
                        PrikaziKorpu();
                        OduzmiKolicinu(idartikla, kolicina);
                        DodajCijenu(kolicina, idartikla);

                        MessageBox.Show("Artikal uspješno dodan!");
                        textBoxIDArtikla.Text = "";
                        numericUpDown1.Value = 0;
                        numericUpDown1.Maximum = 0;
                    }

                    
                    konekcija.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PrikaziKorpu()
        {
            String upit = "SELECT s.stavka_id AS 'ID stavke', s.artikal_id AS 'ID artikla',a.naziv_artikla AS 'Naziv artikla'," +
                "a.cijena AS Cijena, s.količina as Količina FROM stavka_narudžbenice s, artikal a WHERE s.artikal_id=a.artikal_id " +
                "AND narudžbenica_id=" + brnarudzbe;
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);
                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridViewKorpa.DataSource = tabela;
                data.Dispose();

                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OduzmiKolicinu(string idartikla,int kolicina)
        {
            try
            {
                String upit1="SELECT količina_stanje FROM skladiste WHERE artikal_id="+idartikla;
                MySqlConnection konekcija=new MySqlConnection(konekcionistring);
                konekcija.Open();
                MySqlCommand cmd1=new MySqlCommand(upit1,konekcija);
                MySqlDataReader reader=cmd1.ExecuteReader();
                reader.Read();
                int kolicinanastanju=Convert.ToInt32(reader[0])-kolicina;
                reader.Close();

                String upit2 = "UPDATE skladiste SET količina_stanje=" + kolicinanastanju + " WHERE artikal_id=" + idartikla;
                MySqlCommand cmd2 = new MySqlCommand(upit2, konekcija);
                cmd2.ExecuteNonQuery();

                konekcija.Close();

                String upit = "SELECT a.artikal_id AS ID,a.naziv_artikla AS Naziv," +
                "a.vrsta_artikla as Vrsta, cijena as Cijena, s.količina_stanje as 'Količina na stanju'  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
                PrikazArtikala(upit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        double korpatotal;

        private void DodajCijenu(int kolicina,string idartikla)
        {
            try
            {
                String upit = "SELECT cijena FROM artikal WHERE artikal_id="+idartikla;
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();
                MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                double cijena = Convert.ToDouble(reader[0].ToString());
                korpatotal += kolicina * cijena;
                textBoxTotalKorpa.Text = korpatotal.ToString();
                reader.Close();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObrisiKorpa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxIDArtiklaBrisanje.Text == "") errorProvider1.SetError(textBoxIDArtikla, "Obavezno!");
            else if (numericUpDownBrisanjeStavke.Value==0) errorProvider1.SetError(numericUpDownBrisanjeStavke,"Obavezno!");
            else
            {
                try
                {   
                    string idartikla=textBoxIDArtiklaBrisanje.Text;
                    int brojartikala = Convert.ToInt32(numericUpDownBrisanjeStavke.Maximum) - Convert.ToInt32(numericUpDownBrisanjeStavke.Value);
                    String upit="";
                    if (brojartikala == 0)
                    {
                        upit = "DELETE from stavka_narudžbenice WHERE artikal_id=" + idartikla + " AND narudžbenica_id=" + brnarudzbe;
                    }
                    else 
                    {
                        upit="UPDATE stavka_narudžbenice SET količina="+brojartikala+" WHERE artikal_id="+idartikla+" AND narudžbenica_id="+brnarudzbe;
                    }
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Artikal uspješno obrisan!");
                    else
                        MessageBox.Show("Artikal nije u korpi!");
                    PrikaziKorpu();
                    OduzmiCijenu(idartikla, Convert.ToInt32(numericUpDownBrisanjeStavke.Value));
                    VratiKolicinu(Convert.ToInt32(numericUpDownBrisanjeStavke.Value),idartikla);
                    String upitprikaz = "SELECT a.artikal_id AS ID,a.naziv_artikla AS Naziv," +
                    "a.vrsta_artikla as Vrsta, cijena as Cijena, s.količina_stanje as 'Količina na stanju'  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
                    PrikazArtikala(upitprikaz);
                    konekcija.Close();
                    textBoxIDArtiklaBrisanje.Text = "";
                    numericUpDownBrisanjeStavke.Value = 0;
                    numericUpDownBrisanjeStavke.Maximum = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxIDArtiklaBrisanje_TextChanged(object sender, EventArgs e)
        {
            string id = textBoxIDArtiklaBrisanje.Text;
            if (id == "")
            {
                numericUpDownBrisanjeStavke.Value = 0;
                numericUpDownBrisanjeStavke.Maximum = 0;
            }
            else
            {
                String upit = "SELECT s.stavka_id AS 'ID stavke', s.artikal_id AS 'ID artikla',a.naziv_artikla AS 'Naziv artikla'," +
                "a.cijena AS Cijena, s.količina as Količina FROM stavka_narudžbenice s, artikal a WHERE s.artikal_id=a.artikal_id AND s.artikal_id LIKE'" + id +
                "%' AND narudžbenica_id=" + brnarudzbe;
                try
                {
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();

                    MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);
                    DataTable tabela = new DataTable();
                    data.Fill(tabela);

                    dataGridViewKorpa.DataSource = tabela;
                    data.Dispose();
                    konekcija.Close();
                    if (dataGridViewKorpa.Rows.Count != 0)
                    {
                        numericUpDownBrisanjeStavke.Maximum = Convert.ToInt32(dataGridViewKorpa.Rows[0].Cells[4].Value);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

            private void VratiKolicinu(int br,string idartikla)
            {
                try
                {
                    String upit1 = "SELECT količina_stanje FROM skladiste WHERE artikal_id=" + idartikla;
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    MySqlCommand cmd1 = new MySqlCommand(upit1, konekcija);
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    reader.Read();
                    int kolicinanastanju = Convert.ToInt32(reader[0]) + br;
                    reader.Close();

                    String upit2 = "UPDATE skladiste SET količina_stanje=" + kolicinanastanju + " WHERE artikal_id=" + idartikla;
                    MySqlCommand cmd2 = new MySqlCommand(upit2, konekcija);
                    cmd2.ExecuteNonQuery();

                    konekcija.Close();

                    String upit = "SELECT a.artikal_id AS ID,a.naziv_artikla AS Naziv," +
                    "a.vrsta_artikla as Vrsta, cijena as Cijena, s.količina_stanje as 'Količina na stanju'  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
                    PrikazArtikala(upit);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            private void OduzmiCijenu(string idartikla, int br)
            {
                try
                {
                    String upit = "SELECT cijena FROM artikal WHERE artikal_id=" + idartikla;
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    double cijena = Convert.ToDouble(reader[0].ToString());
                    korpatotal -= br * cijena;
                    textBoxTotalKorpa.Text = korpatotal.ToString();
                    reader.Close();
                    konekcija.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (dataGridViewKorpa.Rows.Count-1!= 0)
                {
                    novanarudzba = 0;
                    MessageBox.Show("Narudžba uspješno dodana!");
                    dataGridViewKorpa.DataSource = "none";
                    korpatotal = 0;
                    textBoxTotalKorpa.Text = "";
                    PrikazNarudzbi();
                }
                else
                {
                    MessageBox.Show("Nemate artikala u narudžbi!");
                }
            }


            private void BrisanjeNarudzbe()
            {

                if (novanarudzba == 1)
                {

                    try
                    {
                        String upit = "DELETE FROM stavka_narudžbenice WHERE narudžbenica_id=" + brnarudzbe + ";" +
                            "DELETE FROM narudžbenica WHERE narudžbenica_id=" + brnarudzbe + ";";

                        MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                        konekcija.Open();
                        MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                       int a= cmd.ExecuteNonQuery();
                       novanarudzba = 0;
                       konekcija.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            }
            private void VracanjeDodanihArtikala()
            {
                for (int i = 0; i <dataGridViewKorpa.Rows.Count; i++)
                {
                    int idartikla = Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells[1].Value);
                    int kolicina = Convert.ToInt32(dataGridViewKorpa.Rows[i].Cells[4].Value);

                    String upit = "UPDATE skladiste SET količina_stanje=količina_stanje+" + kolicina + " WHERE artikal_id=" + idartikla;
                    try
                    {
                        MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                        konekcija.Open();

                        MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                        cmd.ExecuteNonQuery();


                        konekcija.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }
}
