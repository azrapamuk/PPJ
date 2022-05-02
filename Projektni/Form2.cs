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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String konekcionistring = Form1.konekcionistr;


        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Lucida Console", 7);

            string upitkupac = "SELECT * FROM kupac;";
            PrikazKorisnika(upitkupac);
            string upitartikal = "SELECT a.artikal_id as 'ID artikla',a.naziv_artikla as Naziv,a.vrsta_artikla as Vrsta,a.cijena as Cijena,"+
                "s.količina_stanje AS 'Količina na stanju' FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
            PrikazArtikala(upitartikal);
            string upitnarudzba = "SELECT n.narudžbenica_id as 'ID narudžbenice',n.kupac_id as 'ID kupca',n.datum_narudžbe as 'Datum narudžbe'"+
            ",k.ime as Ime,k.prezime AS Prezime FROM narudžbenica n,kupac k WHERE n.kupac_id=k.kupac_id";
            PrikazNarudzbe(upitnarudzba);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            string poruka = "Da li ste sigurni da želite zatvoriti ovu stranicu i odjaviti se?";
            string opis = "";

            var result = MessageBox.Show(poruka, opis, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void textBoxTraziIme_TextChanged(object sender, EventArgs e)
        {
            string imetrazi = textBoxTraziIme.Text;
            string traziprezime = textBoxPrezimeTrazi.Text;

            String upit2 = "SELECT * FROM kupac WHERE ime LIKE '" + imetrazi + "%' AND prezime LIKE '" + traziprezime + "%';";

            PrikazKorisnika(upit2);
        }

        private void textBoxPrezimeTrazi_TextChanged(object sender, EventArgs e)
        {
            string imetrazi = textBoxTraziIme.Text;
            string traziprezime = textBoxPrezimeTrazi.Text;

            String upit2 = "SELECT * FROM kupac WHERE ime LIKE '" + imetrazi + "%' AND prezime LIKE '" + traziprezime + "%';";

            PrikazKorisnika(upit2);
        }

        private void PrikazKorisnika(string upit)
        {

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridView1.DataSource = tabela;

                data.Dispose();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public int p;

        private void buttonKreirajKupca_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            ProvjeraPodatakaZaAzuriranje();

            if (p == 0)
            {
                string ime = textBoxIme.Text;
                string prezime = textBoxPrezime.Text;
                string grad = textBoxGrad.Text;
                string adresa = textBoxAdresa.Text;
                string telefon = textBoxTelefon.Text;
                string korime = textBoxKorIme.Text;
                string sifra = textBoxSifra.Text;

                String upitprovjera = "SELECT * FROM kupac WHERE user='"+korime+"';";

                String upit = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass)" +
                               "VALUES('" + ime + "','" + prezime + "','" + grad + "','" + adresa + "','" + telefon + "','" + korime + "','" + sifra + "');";

                try
                {
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand(upitprovjera, konekcija);
                    MySqlDataReader reader1 = cmd.ExecuteReader();
                    reader1.Read();
                        if (reader1.HasRows)
                        {
                            errorProvider1.SetError(textBoxKorIme, "Korisničko ime zauzeto!");
                            reader1.Close();
                        }
                        else
                        {
                            reader1.Close();
                            MySqlCommand cmd1 = new MySqlCommand(upit, konekcija);

                            cmd1.ExecuteNonQuery();

                            MessageBox.Show("Kupac uspješno dodan!");

                            textBoxIme.Text = "";
                            textBoxPrezime.Text = "";
                            textBoxGrad.Text = "";
                            textBoxAdresa.Text = "";
                            textBoxTelefon.Text = "";
                            textBoxKorIme.Text = "";
                            textBoxSifra.Text = "";

                        }

                    reader1.Close();
                    konekcija.Close();
                    string upit1 = "SELECT * FROM kupac;";
                    PrikazKorisnika(upit1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxIDKupacAzuriraj_TextChanged(object sender, EventArgs e)
        {
            string id = textBoxIDKupacAzuriraj.Text;
            if (id != "")
            {
                try
                {
                    String upit = "SELECT * FROM kupac WHERE kupac_id=" + id;
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        textBoxIme.Text = reader[1].ToString();
                        textBoxPrezime.Text = reader[2].ToString();
                        textBoxGrad.Text = reader[3].ToString();
                        textBoxAdresa.Text = reader[4].ToString();
                        textBoxTelefon.Text = reader[5].ToString();
                        textBoxKorIme.Text = reader[6].ToString();
                        textBoxSifra.Text = reader[7].ToString();
                    }
                    else
                    {

                        textBoxIme.Text = "";
                        textBoxPrezime.Text = "";
                        textBoxGrad.Text = "";
                        textBoxAdresa.Text = "";
                        textBoxTelefon.Text = "";
                        textBoxKorIme.Text = "";
                        textBoxSifra.Text = "";
                    }

                    reader.Close();
                    konekcija.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxAdresa.Text = "";
                textBoxTelefon.Text = "";
                textBoxKorIme.Text = "";
                textBoxSifra.Text = "";
            }
        }

        private void buttonAzurirajKupca_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ProvjeraPodatakaZaAzuriranje();
            if (textBoxIDKupacAzuriraj.Text == "") errorProvider1.SetError(textBoxIDKupacAzuriraj, "Obavezno!");
            else
            {
                if (p == 0)
                {
                    try
                    {
                        string id = textBoxIDKupacAzuriraj.Text;
                        string ime = textBoxIme.Text;
                        string prezime = textBoxPrezime.Text;
                        string grad = textBoxGrad.Text;
                        string adresa = textBoxAdresa.Text;
                        string telefon = textBoxTelefon.Text;
                        string korime = textBoxKorIme.Text;
                        string sifra = textBoxSifra.Text;

                        String upit = "UPDATE kupac set ime='" + ime + "',prezime='" + prezime + "',grad='" + grad +
                            "',adresa='" + adresa + "',telefon='" + telefon + "',user='" + korime + "',pass='" + sifra + "'" +
                            " WHERE kupac_id=" + id + ";";
                        String upitprovjera = "SELECT * FROM kupac WHERE user='" + korime+"' AND kupac_id<>"+id;

                        MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                        konekcija.Open();

                        MySqlCommand cmdprovjera = new MySqlCommand(upitprovjera, konekcija);
                        MySqlDataReader reader = cmdprovjera.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            errorProvider1.SetError(textBoxKorIme, "Korisničko ime zauzeto!");
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                            int a = cmd.ExecuteNonQuery();



                            if (a > 0)
                            {
                                MessageBox.Show("Podaci kupca uspješno ažurirani!");
                                textBoxIme.Text = "";
                                textBoxPrezime.Text = "";
                                textBoxGrad.Text = "";
                                textBoxAdresa.Text = "";
                                textBoxTelefon.Text = "";
                                textBoxKorIme.Text = "";
                                textBoxSifra.Text = "";
                                textBoxIDKupacAzuriraj.Text = "";

                            }
                            else
                                MessageBox.Show("Kupac ne postoji!");
                            reader.Close();
                            konekcija.Close();
                            string upit1 = "SELECT * FROM kupac;";
                            PrikazKorisnika(upit1);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private int ProvjeraPodatakaZaAzuriranje()
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string grad = textBoxGrad.Text;
            string adresa = textBoxAdresa.Text;
            string telefon = textBoxTelefon.Text;
            string korime = textBoxKorIme.Text;
            string sifra = textBoxSifra.Text;

            if (ime == "")
            {
                errorProvider1.SetError(textBoxIme, "Obavezno!");
                p = 1;
                return p;
            }
            else if (prezime == "")
            {
                errorProvider1.SetError(textBoxPrezime, "Obavezno!");
                p = 1;
                return p;
            }
            else if (grad == "")
            {
                errorProvider1.SetError(textBoxGrad, "Obavezno!");
                p = 1;
                return p;
            }
            else if (adresa == "")
            {
                errorProvider1.SetError(textBoxAdresa, "Obavezno!");
                p = 1;
                return p;
            }
            else if (telefon == "")
            {
                errorProvider1.SetError(textBoxTelefon, "Obavezno!");
                p = 1;
                return p;
            }
            else if (korime == "")
            {
                errorProvider1.SetError(textBoxKorIme, "Obavezno!");
                p = 1;
                return p;
            }
            else if (sifra == "")
            {
                errorProvider1.SetError(textBoxSifra, "Obavezno!");
                p = 1;
                return p;
            }
            else
            {
                p = 0;
                return p;
            }
        }

        //ZA ARTIKLE

        private void PrikazArtikala(string upit)
        {
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridView3.DataSource = tabela;

                data.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void textBoxSifraTrazi_TextChanged(object sender, EventArgs e)
        {
            string sifra = textBoxSifraTrazi.Text;
            string naziv = textBoxNazivTrazi.Text;

            try
            {
                String upit = "SELECT * FROM artikal WHERE artikal_id LIKE '" + sifra + "%' and naziv_artikla LIKE '" + naziv + "%';";
                PrikazArtikala(upit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxNazivTrazi_TextChanged(object sender, EventArgs e)
        {
            string sifra = textBoxSifraTrazi.Text;
            string naziv = textBoxNazivTrazi.Text;

            try
            {
                String upit = "SELECT * FROM artikal WHERE artikal_id LIKE '" + sifra + "%' and naziv_artikla LIKE '" + naziv + "%';";
                PrikazArtikala(upit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int p2;


        private int ProvjeraZaArtikal()
        {
            if (textBoxNazivArtikla.Text == "")
            {
                errorProvider1.SetError(textBoxNazivArtikla, "Obavezno!");
                p2 = 1;
            }
            else if (textBoxVrstaArtikla.Text == "")
            {
                errorProvider1.SetError(textBoxVrstaArtikla, "Obavezno!");
                p2 = 1;
            }
            else if (textBoxCijenaArtikla.Text == "")
            {
                errorProvider1.SetError(textBoxCijenaArtikla, "Obavezno!");
                p2 = 1;
            }
            else if (textBoxKolicinaArtikala.Text == "")
            {
                errorProvider1.SetError(textBoxKolicinaArtikala, "Obavezno!");
                p2 = 1;
            }
            else p2 = 0;
            return p2;
        }

        private void buttonDodajArtikal_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ProvjeraZaArtikal();
            if (p2 == 0)
            {
                try
                {
                    string naziv = textBoxNazivArtikla.Text;
                    string vrsta = textBoxVrstaArtikla.Text;
                    string cijena = textBoxCijenaArtikla.Text;
                    string kolicina = textBoxKolicinaArtikala.Text;


                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();

                    String upit0 = "SELECT COUNT(*) from artikal";

                    MySqlCommand cmd0 = new MySqlCommand(upit0, konekcija);
                    MySqlDataReader reader = cmd0.ExecuteReader();
                    reader.Read();

                    int brartikala = Convert.ToInt32(reader[0]) + 1;
                    reader.Close();

                    String upit1 = "INSERT INTO artikal(naziv_artikla,vrsta_artikla,cijena) VALUES('" + naziv + "','" + vrsta + "','" + cijena + "');" +
                                    " INSERT INTO skladiste(artikal_id,količina_stanje) VALUES(" + brartikala.ToString() + "," + kolicina + ");";


                    MySqlCommand cmd1 = new MySqlCommand(upit1, konekcija);

                    int a = cmd1.ExecuteNonQuery();


                    konekcija.Close();

                    if (a > 0)
                    {
                        MessageBox.Show("Artikal upsješno dodan!");
                        textBoxNazivArtikla.Text = "";
                        textBoxVrstaArtikla.Text = "";
                        textBoxCijenaArtikla.Text = "";
                        textBoxKolicinaArtikala.Text = "";
                    }
                    else
                        MessageBox.Show("Greška pri dodavanju artikla!");

                    PrikazArtikala("SELECT a.*,s.količina_stanje  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void textBoxIDartikla_TextChanged(object sender, EventArgs e)
        {
            string id = textBoxIDartikla.Text;
            if (id != "")
            {
                try
                {
                    String upit = "SELECT a.*,s.količina_stanje  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id AND a.artikal_id=" + id + ";";
                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                    konekcija.Open();
                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {

                        textBoxNazivArtikla.Text = reader[1].ToString();
                        textBoxVrstaArtikla.Text = reader[2].ToString();
                        textBoxCijenaArtikla.Text = reader[3].ToString();
                        textBoxKolicinaArtikala.Text = reader[4].ToString();
                    }
                    else
                    {
                        textBoxNazivArtikla.Text = "";
                        textBoxVrstaArtikla.Text = "";
                        textBoxCijenaArtikla.Text = "";
                        textBoxKolicinaArtikala.Text = "";
                    }

                    reader.Close();
                    konekcija.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                textBoxNazivArtikla.Text = "";
                textBoxVrstaArtikla.Text = "";
                textBoxCijenaArtikla.Text = "";
                textBoxKolicinaArtikala.Text = "";
            }
        }

        private void buttonAzurirajArtikal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ProvjeraZaArtikal();
            if (p2 == 0)
            {
                try
                {
                    string id = textBoxIDartikla.Text;
                    string naziv = textBoxNazivArtikla.Text;
                    string vrsta = textBoxVrstaArtikla.Text;
                    string cijena = textBoxCijenaArtikla.Text;
                    int kolicina = Convert.ToInt32(textBoxKolicinaArtikala.Text) + Convert.ToInt32(numericUpDownKolicina.Value);

                    String upit = "UPDATE artikal a, skladiste s SET a.naziv_artikla='" + naziv + "',vrsta_artikla='" + vrsta + "',cijena=" + cijena +
                                ",s.količina_stanje=" + kolicina.ToString() + " WHERE a.artikal_id=" + id + " AND a.artikal_id=s.artikal_id;";

                    MySqlConnection konekcija = new MySqlConnection(konekcionistring);

                    konekcija.Open();

                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("Artikal uspješno ažuriran!");
                        string upitprikaz = "SELECT a.*,s.količina_stanje  FROM artikal a, skladiste s WHERE a.artikal_id=s.artikal_id;";
                        PrikazArtikala(upitprikaz);
                        textBoxIDartikla.Text = "";
                        textBoxNazivArtikla.Text = "";
                        textBoxVrstaArtikla.Text = "";
                        textBoxCijenaArtikla.Text = "";
                        textBoxKolicinaArtikala.Text = "";
                        numericUpDownKolicina.Value = 0;
                    }
                    else
                        MessageBox.Show("Artikal ne postoji!");

                    konekcija.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //ZA PRIKAZ/BRISANJE NARUDŽBE

        private void PrikazNarudzbe(string upit)
        {
            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlDataAdapter data = new MySqlDataAdapter(upit, konekcija);

                DataTable tabela = new DataTable();
                data.Fill(tabela);

                dataGridView2.DataSource = tabela;

                data.Dispose();

                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBoxNarudzba.Text=="") errorProvider1.SetError(textBoxNarudzba,"Obavezno!");
            else
            {
            try
            {

                String upit = "DELETE FROM stavka_narudžbenice WHERE narudžbenica_id=" + textBoxNarudzba.Text + ";" +
                              "DELETE FROM narudžbenica WHERE narudžbenica_id=" + textBoxNarudzba.Text + ";";
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Narudžba uspješno obrisana!");
                    string upitprikaz = "SELECT n.*,k.ime,k.prezime FROM narudžbenica n,kupac k WHERE n.kupac_id=k.kupac_id";
                    PrikazNarudzbe(upitprikaz);
                    textBoxNarudzba.Text = "";
                }
                else
                    MessageBox.Show("Narudžba ne postoji!");

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

