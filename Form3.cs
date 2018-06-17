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
    public partial class Form3 : Form
    {
        int sayac = 0;
        string dizin;
        public bool ToRestart = false;

        public Form3()
        {
            InitializeComponent();
            yvrlkBtn1.Hide();
            ResetButons();
            btn2.Enabled = true;
            btn2.ForeColor = Color.White;
            picBox2.Visible = true;
        }

        private void NewMethod1()
        {
            SoundPlayer ses = new SoundPlayer();
            dizin = Application.StartupPath + "\\sesler\\" + sayac.ToString() + ".wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn1.BackColor = Color.Green;
            label1.Text += "-";
            label1.Text += sayac.ToString();
            yvrlkBtn1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn3.ForeColor = Color.White;
            btn3.Enabled = true;
            btn2.BackColor = Color.Green;
            picBox3.Visible = true;
            label1.Text += sayac.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1(); ;
            }
            else { }
            ResetButons();
            btn4.ForeColor = Color.White;
            btn4.Enabled = true;
            btn3.BackColor = Color.Green;
            picBox4.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn5.ForeColor = Color.White;
            btn5.Enabled = true;
            btn4.BackColor = Color.Green;
            picBox5.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void ResetButons()
        {

            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn8.BackColor = Color.Red;
            btn9.BackColor = Color.Red;
            btn10.BackColor = Color.Red;

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;

            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            picBox4.Visible = false;
            picBox5.Visible = false;
            picBox6.Visible = false;
            picBox7.Visible = false;
            picBox8.Visible = false;
            picBox9.Visible = false;
            picBox10.Visible = false;

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

        private void btn5_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn6.ForeColor = Color.White;
            btn6.Enabled = true;
            btn5.BackColor = Color.Green;
            picBox6.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn7.ForeColor = Color.White;
            btn7.Enabled = true;
            btn6.BackColor = Color.Green;
            picBox7.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn8.ForeColor = Color.White;
            btn8.Enabled = true;
            btn7.BackColor = Color.Green;
            picBox8.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn9.ForeColor = Color.White;
            btn9.Enabled = true;
            btn8.BackColor = Color.Green;
            picBox9.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn10.ForeColor = Color.White;
            btn10.Enabled = true;
            btn9.BackColor = Color.Green;
            picBox10.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            sayac += 3;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            else { }
            ResetButons();
            btn1.ForeColor = Color.White;
            btn1.Enabled = true;
            btn10.BackColor = Color.Green;
            picBox1.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yvrlkBtn1_Click(object sender, EventArgs e)
        {
            ToRestart = true;
            this.Close();

            Form3 form3 = new Form3();
            form3.Show();
        }


    }
}
