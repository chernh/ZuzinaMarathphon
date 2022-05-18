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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form BMI = new BMI();
            BMI.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form BMR = new BMR();
            BMR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form about = new about();
            about.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Form blag = new blag();
            blag.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form res = new res();
            res.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form @long = new @long();
            @long.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }
    }
}
