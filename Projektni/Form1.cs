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

        String konekcionistring = "Server=localhost; Port=3306; Database=projekat;Uid=root;Pwd=azra";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Prijava(); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Prijava()
        {
            errorProvider1.Clear();

            string korime = textBoxKorisnickoIme.Text;
            string sifra = textBoxSifra.Text;

            String upit = "SELECT pass, kupac_id FROM kupac WHERE user='" + korime + "';";
            

            try
            {
                MySqlConnection konekcija = new MySqlConnection(konekcionistring);
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
                        if (reader[1].ToString() == "1")
                        {
                            Administrator();
                        }
                        else
                        {
                            Kupac();
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

        private void Administrator()
        {
            this.Hide();
            Form2 f2=new Form2();
            f2.Show();
        }

        private void Kupac()
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
