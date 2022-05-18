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
    public partial class spon : Form
    {
        public spon()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e) //-
        {
            int x = Convert.ToInt32(textBox7.Text);
            textBox7.Text = Convert.ToString(x - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox7.Text);
            textBox7.Text = Convert.ToString(x + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form podspon = new podspon();
            podspon.Show();
        }
    }
}
