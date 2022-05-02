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
    public partial class Form1 : Form
    {

        public static String konekcionistr = "Server=localhost; Port=3306; Database=projekt;Uid=root;Pwd=azra";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Prijava(); 
        }

        public static String kupacID;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Prijava()
        {
            errorProvider1.Clear();

            string korime = textBoxKorisnickoIme.Text;
            string sifra = textBoxSifra.Text;

            String upit = "SELECT pass, kupac_id,ime FROM kupac WHERE user='" + korime + "';";
            

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistr);
                konekcija.Open();

                MySqlCommand cmd = new MySqlCommand(upit, konekcija);

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                if (!reader.HasRows)
                {
                    errorProvider1.SetError(textBoxKorisnickoIme, "Pogrešno korisničko ime!");
                }
                else
                {
                    if (sifra != reader[0].ToString())
                    {
                        errorProvider1.SetError(textBoxSifra, "Pogrešna šifra!");
                    }
                    else
                    {
                        kupacID = reader[1].ToString();

                        string ime = reader[2].ToString();
                        if (kupacID == "1")
                        {
                            Administrator(ime);
                        }
                        else
                        {
                            Kupac(ime);
                        }
                    }
                }
                reader.Close();
                konekcija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Administrator(string imelogin)
        {
            MessageBox.Show("Dobrodošli " + imelogin + "!");
            this.Hide();
            Form2 f2=new Form2();
            f2.Show();
        }

        private void Kupac(string imelogin)
        {
            MessageBox.Show("Dobrodošli " + imelogin + "!");
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
