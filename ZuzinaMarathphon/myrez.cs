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
    public partial class myrez : Form
    {
        public myrez()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form res = new res();
            res.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }
    }
}
