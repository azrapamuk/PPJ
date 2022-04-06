using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
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
    }
}
