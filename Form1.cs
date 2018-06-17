using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitmikSayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form12 İkişerSayma = new Form12();
            İkişerSayma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ÜçerSayma = new Form3();
            ÜçerSayma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 DörderSayma = new Form4();
            DörderSayma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 BeşerSayma = new Form5();
            BeşerSayma.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 AltışarSayma = new Form6();
            AltışarSayma.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 YedişerSayma = new Form7();
            YedişerSayma.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 SekizerSayma = new Form8();
            SekizerSayma.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 DokuzarSayma = new Form9();
            DokuzarSayma.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 OnarSayma = new Form10();
            OnarSayma.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ufuk-ekici-66244b147/");
        }

        private void lnkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mustafa-kara-85a3b6148/");
        }
    }
}
