using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuzinaMarathphon
{
    public partial class BMR : Form
    {
        float gender;
        float v;
        float r;
        float a;
        
        public BMR()
        {
            InitializeComponent();
            panel1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) //рассчитать
        {
            float weight = float.Parse(ves.Text);
            float height = float.Parse(rost.Text);
            float age = float.Parse(ag.Text);
            float bmr = gender + (v * weight) + (r * height) - (a * age);
            x.Text = bmr.ToString();
            double ced;
            ced = (bmr * (1.2));
            label21.Text = ced.ToString();
            double mal;
            mal = (bmr * (1.375));
            label22.Text = mal.ToString();
            double sr;
            sr = (bmr * (1.55));
            label23.Text = sr.ToString();
            double sil;
            sil = (bmr * (1.725));
            label24.Text = sil.ToString();
            double max;
            max = (bmr * (1.9));
            label25.Text = max.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gender = 665;
            v = 9.6f;
            r = 1.8f;
            a = 4.7f;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gender = 66;
            v = 13.7f;
            r = 5;
            a = 6.8f;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gender = 0;
            rost.Clear();
            ves.Clear();
            ag.Clear();
            x.Text = "BMR";
            label21.Text = " ";
            label22.Text = " ";
            label23.Text = " ";
            label24.Text = " ";
            label25.Text = " ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form info = new info();
            info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }
    }
}
