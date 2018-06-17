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
    public partial class Form12 : Form
    {
        private Graphics grafiknesne;
        Pen firca = new Pen(System.Drawing.Color.Black, 5);
        int sayac = 0;
        string dizin;

        public bool ToRestart = false;

        public Form12()
        {
            InitializeComponent();

            btn5.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn4.Enabled = false;
            btn3.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;

            yvrlkBtn1.Hide();
        }

        int x = 0, y = 0, enx = 0, eny = 0;

        private void yvrlkBtn1_Click(object sender, EventArgs e)
        {
            ToRestart = true;
            this.Close();

            Form12 form11 = new Form12();
            form11.Show();
        }

        private void NewMethod(out Graphics grafik, out Pen firca)
        {
            grafik = this.CreateGraphics();
            firca = new Pen(System.Drawing.Color.Black, 5);
            grafik.DrawLine(firca, x, y, enx, eny);

        }

        private void say()
        {
            sayac += 2;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (label1.Text == "")
            {
                sayac += 2;
                NewMethod1();
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(172, 212, 628, 531);
                label1.Text += sayac.ToString();
                ResetButons();
                btn9.ForeColor = Color.White;
                btn9.Enabled = true;
                btn5.BackColor = Color.Green;
            }
            else
            {
                this.grafiknesne.Clear(Color.White);
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(172, 212, 628, 531);
                say();
                NewMethod1();
                ResetButons();
                btn9.ForeColor = Color.White;
                btn9.Enabled = true;
                btn5.BackColor = Color.Green;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(628, 212, 169, 212);
            say();
            NewMethod1();
            ResetButons();
            btn3.ForeColor = Color.White;
            btn3.Enabled = true;
            btn9.BackColor = Color.Green;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(171, 531, 628, 212);
            say();
            NewMethod1();
            ResetButons();
            btn7.ForeColor = Color.White;
            btn7.Enabled = true;
            btn3.BackColor = Color.Green;
        }



        private void btn7_Click(object sender, EventArgs e)
        {
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(401, 80, 171, 531);
            say();
            NewMethod1();
            ResetButons();
            btn1.ForeColor = Color.White;
            btn1.Enabled = true;
            btn7.BackColor = Color.Green;

        }

        int tik = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            tik += 1;
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(628, 531, 399, 80);
            say();
            NewMethod1();
            ResetButons();
            btn5.ForeColor = Color.White;
            btn5.Enabled = true;
            btn1.BackColor = Color.Green;

            if (tik == 2)
            {
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(628, 531, 400, 80);
                NewMethod1();
                ResetButons();
                yvrlkBtn1.Show();
            }
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

        private void ResetButons()
        {

            btn1.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn9.BackColor = Color.Red;

            btn1.Enabled = false;
            btn3.Enabled = false;
            btn5.Enabled = false;
            btn7.Enabled = false;
            btn9.Enabled = false;

            btn1.ForeColor = Color.DarkGray;
            btn2.ForeColor = Color.DarkGray;
            btn3.ForeColor = Color.DarkGray;
            btn4.ForeColor = Color.DarkGray;
            btn5.ForeColor = Color.DarkGray;
            btn6.ForeColor = Color.DarkGray;
            btn7.ForeColor = Color.DarkGray;
            btn8.ForeColor = Color.DarkGray;
            btn9.ForeColor = Color.DarkGray;
            btn10.ForeColor = Color.DarkGray;

            dizin = "";
        }

        private void DrawLineAnimation(float sx, float sy, float ex, float ey)
        {
            float stepX = (sx - ex) / 10;
            float stepY = (sy - ey) / 10;
            for (int i = 1; i <= 10; i++)
            {
                grafiknesne.DrawLine(firca, ex, ey, (ex + stepX * i), (ey + stepY * i));
                System.Threading.Thread.Sleep(20);
            }
        }


    }
}
