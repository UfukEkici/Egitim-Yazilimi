using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RitmikSayılar
{
    public partial class Form5 : Form
    {
        int sayac = 0;
        int klik = 0;
        string dizin;


        public Form5()
        {
            InitializeComponent();
            yvrlkBtn1.Hide();
            picBox1.Visible = false;
            btn1.Enabled = false;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            sayac += 5;
            NewMethod1();
            klik++;
            btn1.Text = "0";
            btn1.ForeColor = Color.DarkGray;
            btn6.ForeColor = Color.White;
            btn1.Enabled = false;
            btn6.Enabled = true;
            btn1.BackColor = Color.Red;
            btn6.BackColor = Color.Green;
            picBox6.Visible = true;
            picBox1.Visible = false;
            label1.Text += "-";
            label1.Text += sayac.ToString();

            if (klik == 5)
            {
                btn1.Enabled = false;
                btn6.Enabled = false;
                picBox6.Visible = false;
                btn6.BackColor = Color.Red;
                yvrlkBtn1.Show();
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            sayac += 5;
            NewMethod1();
            btn6.Text = "5";
            btn6.ForeColor = Color.DarkGray;
            btn1.ForeColor = Color.White;
            btn1.Enabled = true;
            btn6.Enabled = false;
            btn6.BackColor = Color.Red;
            btn1.BackColor = Color.Green;
            picBox1.Visible = true;
            picBox6.Visible = false;
            label2.Visible = false;

            if (label1.Text == "")
            {
                label1.Text += sayac.ToString();
            }
            else
            {
                label1.Text += "-";
                label1.Text += sayac.ToString();

            }
        }

        public bool ToRestart = false;

        private void yvrlkBtn1_Click(object sender, EventArgs e)
        {
            ToRestart = true;
            this.Close();

            Form5 form5 = new Form5();
            form5.Show();
        }
        private void NewMethod(out Graphics grafik, out Pen firca)
        {
            grafik = panel1.CreateGraphics();
            firca = new Pen(System.Drawing.Color.Black, 5);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafiknesne;
            Pen firca;
            NewMethod(out grafiknesne, out firca);
            grafiknesne.DrawLine(firca, 100, 570, 100, 192);
            grafiknesne.DrawLine(firca, 100, 192, 400, 6);
            grafiknesne.DrawLine(firca, 400, 6, 700, 192);
            grafiknesne.DrawLine(firca, 700, 192, 700, 570);
            grafiknesne.DrawLine(firca, 700, 570, 100, 570);
        }

        private void NewMethod1()
        {
            if (checkBox1.Checked == false)
            {
                SoundPlayer ses = new SoundPlayer();
                dizin = Application.StartupPath + "\\sesler\\" + sayac.ToString() + ".wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }

            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
