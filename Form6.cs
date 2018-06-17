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
    public partial class Form6 : Form
    {
        int sayac = 0;
        string dizin;

        public Form6()
        {
            InitializeComponent();
            ResetButons();
            btn3.Enabled = true;
            picBox3.Visible = true;
            yvrlkBtn1.Hide();
        }

        public bool ToRestart = false;

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

            picBox1.Visible = false;
            picBox3.Visible = false;
            picBox5.Visible = false;
            picBox7.Visible = false;
            picBox9.Visible = false;

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

        private void NewMethod1()
        {
            SoundPlayer ses = new SoundPlayer();
            dizin = Application.StartupPath + "\\sesler\\" + sayac.ToString() + ".wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yvrlkBtn1_Click(object sender, EventArgs e)
        {
            ToRestart = true;
            this.Close();

            Form6 form6 = new Form6();
            form6.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sayac += 6;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            if (sayac == 36)
            { label1.Text += "-"; }
            ResetButons();
            btn5.ForeColor = Color.White;
            btn5.Enabled = true;
            btn3.BackColor = Color.Green;
            picBox5.Visible = true;
            label1.Text += sayac.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sayac += 6;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            ResetButons();
            btn7.ForeColor = Color.White;
            btn7.Enabled = true;
            btn5.BackColor = Color.Green;
            picBox7.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sayac += 6;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            ResetButons();
            btn9.ForeColor = Color.White;
            btn9.Enabled = true;
            btn7.BackColor = Color.Green;
            picBox9.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sayac += 6;
            if (checkBox1.Checked == false)
            {
                NewMethod1();
            }
            ResetButons();
            btn1.ForeColor = Color.White;
            btn1.Enabled = true;
            btn9.BackColor = Color.Green;
            picBox1.Visible = true;
            label1.Text += "-";
            label1.Text += sayac.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sayac += 6;
            if (sayac == 60)
            {
                if (checkBox1.Checked == false)
                {
                    NewMethod1();
                }
                ResetButons();
                btn1.BackColor = Color.Green;
                label1.Text += "-";
                label1.Text += sayac.ToString();
                yvrlkBtn1.Show();
            }
            else
            {
                if (checkBox1.Checked == false)
                {
                    NewMethod1();
                }
                ResetButons();
                btn3.ForeColor = Color.White;
                btn3.Enabled = true;
                btn1.BackColor = Color.Green;
                picBox3.Visible = true;
                label1.Text += "-";
                label1.Text += sayac.ToString();
            }
        }
    }
}
