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
    public partial class Form8 : Form
    {
        private Graphics grafiknesne;
        Pen firca = new Pen(System.Drawing.Color.Black, 5);
        int sayac = 0;
        string dizin;

        public bool ToRestart = false;

        public Form8()
        {
            InitializeComponent();

            btn7.Enabled = true;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn4.Enabled = false;
            btn3.Enabled = false;
            btn6.Enabled = false;
            btn5.Enabled = false;
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

            Form8 form8 = new Form8();
            form8.Show();
        }

        private void NewMethod(out Graphics grafik, out Pen firca)
        {
            grafik = this.CreateGraphics();
            firca = new Pen(System.Drawing.Color.Black, 5);
            grafik.DrawLine(firca, x, y, enx, eny);

        }

        private void say()
        {
            sayac += 8;
            label1.Text += "-";
            label1.Text += sayac.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(399, 80, 627, 531);
                say();
                NewMethod1();
                ResetButons();
                btn1.ForeColor = Color.White;
                btn1.Enabled = true;
                btn5.BackColor = Color.Green;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(628, 531, 169, 212);
            say();
            NewMethod1();
            ResetButons();
            btn5.ForeColor = Color.White;
            btn5.Enabled = true;
            btn9.BackColor = Color.Green;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(171, 212, 627, 212);
            say();
            NewMethod1();
            ResetButons();
            btn9.ForeColor = Color.White;
            btn9.Enabled = true;
            btn3.BackColor = Color.Green;
        }



        private void btn7_Click(object sender, EventArgs e)
        {
            sayac += 8;
            if (label1.Text == "")
            {
                label1.Text += sayac.ToString();
                NewMethod1();
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(628, 212, 171, 531);
                ResetButons();
                btn3.ForeColor = Color.White;
                btn3.Enabled = true;
                btn7.BackColor = Color.Green;
                picBox3.Visible = false;
            }
            else
            {
                label1.Text += "-" + sayac.ToString();
                NewMethod1();
                this.grafiknesne.Clear(Color.White);
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(628, 212, 171, 531);
                ResetButons();
                btn3.ForeColor = Color.White;
                btn3.Enabled = true;
                btn7.BackColor = Color.Green;
            }

        }

        int tik = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            tik += 1;
            grafiknesne = this.CreateGraphics();
            DrawLineAnimation(171, 531, 401, 80);
            say();
            NewMethod1();
            ResetButons();
            btn7.ForeColor = Color.White;
            btn7.Enabled = true;
            btn1.BackColor = Color.Green;

            if (tik == 2)
            {
                grafiknesne = this.CreateGraphics();
                DrawLineAnimation(171, 531, 401, 80);
                ResetButons();
                btn1.BackColor = Color.Green;
                yvrlkBtn1.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafik;
            Pen firca;
            NewMethod(out grafik, out firca);
            grafik.DrawLine(firca, 100, 570, 100, 192);
            grafik.DrawLine(firca, 100, 192, 400, 6);
            grafik.DrawLine(firca, 400, 6, 700, 192);
            grafik.DrawLine(firca, 700, 192, 700, 570);
            grafik.DrawLine(firca, 700, 570, 100, 570);
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
