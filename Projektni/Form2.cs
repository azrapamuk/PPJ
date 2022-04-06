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

        String konekcionistring = "Server=localhost; Port=3306; Database=projekat;Uid=root;Pwd=azra";



        private void Form2_Load(object sender, EventArgs e)
        {
            string upitkupac = "SELECT * FROM kupac;";
            PrikazKorisnika(upitkupac);
            string upitartikal = "SELECT * FROM artikal;";
            PrikazArtikala(upitartikal);
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

        private void buttonTraziKupac_Click(object sender, EventArgs e)
        {
            string imetrazi = textBoxTraziIme.Text;
            string traziprezime = textBoxPrezimeTrazi.Text;

            String upit2 = "SELECT * FROM kupac WHERE ime LIKE '" + imetrazi + "%' AND prezime LIKE '" + traziprezime + "%';";

            PrikazKorisnika(upit2);

        }


        private void buttonKreirajKupca_Click(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string grad = textBoxGrad.Text;
            string adresa = textBoxAdresa.Text;
            string telefon = textBoxTelefon.Text;
            string korime = textBoxKorIme.Text;
            string sifra = textBoxSifra.Text;

            String upit = "INSERT INTO kupac(ime,prezime,grad,adresa,telefon,user,pass)" +
                           "VALUES('" + ime + "','" + prezime + "','" + grad + "','" + adresa + "','" + telefon + "','" + korime + "','" + sifra + "');";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                cmd.ExecuteNonQuery();

                konekcija.Close();

                MessageBox.Show("Kupac uspješno dodan!");

                string upit1 = "SELECT * FROM kupac;";
                PrikazKorisnika(upit1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAzurirajKupca_Click(object sender, EventArgs e)
        {
            string id = textBoxIDKupacAzuriraj.Text;
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string grad = textBoxGrad.Text;
            string adresa = textBoxAdresa.Text;
            string telefon = textBoxTelefon.Text;
            string korime = textBoxKorIme.Text;
            string sifra = textBoxSifra.Text;

            String upit = "UPDATE kupac set ime='"+ ime +"',prezime='" + prezime + "',grad='" + grad +
                "',adresa='" + adresa + "',telefon='" + telefon + "',user='" + korime + "',pass='" + sifra + "'"+
                " WHERE kupac_id="+id+";";

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                int a=cmd.ExecuteNonQuery();

                konekcija.Close();

                if (a > 0)
                    MessageBox.Show("Podaci kupca uspješno ažurirani!");
                else
                    MessageBox.Show("Kupac ne postoji!");

                string upit1 = "SELECT * FROM kupac;";
                PrikazKorisnika(upit1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                dataGridView3.DataSource = tabela;

                data.Dispose();
                konekcija.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
