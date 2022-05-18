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
    public partial class menukoord : Form
    {
        public menukoord()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form ms = new mainscreen();
            ms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form obzorspon = new obzorspon();
            obzorspon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form uprbeg = new uprbeg();
            uprbeg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form ms = new mainscreen();
            ms.Show();
        }
    }
}
