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
    public partial class Proverka : Form
    {
        public Proverka()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form login = new login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form regbeg = new regbeg();
            regbeg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form login = new login();
            login.Show();
        }
    }
}
