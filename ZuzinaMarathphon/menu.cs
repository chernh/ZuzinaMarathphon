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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form edit = new edit();
            edit.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form myrez = new myrez();
            myrez.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Form myspon = new myspon();
            myspon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new regmar().Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            label4.Text = login.LoginMail;
        }
    }
}
