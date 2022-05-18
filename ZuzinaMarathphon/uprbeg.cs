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
    public partial class uprbeg : Form
    {
        public uprbeg()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menukoord = new menukoord();
            menukoord.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }
    }
}
