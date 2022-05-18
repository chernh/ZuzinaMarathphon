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
    public partial class BMI : Form
    {
        float index;
        float r;
        float v;
        public BMI()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // рассчёт BMI
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r = r / 100;
            index = v / (r * r);
            x.Text = index.ToString("N");
            trackBar1.Value = (int)index;

            if (index < (18.5))
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("недостаточный вес");
            }


            if ((index > (18.5)) && ((index < ((24.9)))))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("здоровый вес");
            }



            if ((index > (25)) && ((index < ((29.9)))))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Избыточный вес");
            }



            if (index > (30))
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ожирение");
            }
        }

        private void button2_Click(object sender, EventArgs e) // отмена
        {
            rost.Clear();
            ves.Clear();
            listBox1.Items.Clear();
            trackBar1.Value = 0;
            x.Text = "BMI";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image.Clone() as Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image.Clone() as Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form BMR = new BMR();
            BMR.ShowDialog();
            BMR.Dispose();
            Show();
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
