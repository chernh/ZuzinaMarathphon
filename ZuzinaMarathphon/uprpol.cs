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
    public partial class uprpol : Form
    {
        public uprpol()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new menuadmin().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            new redpol().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new dobpol().Show();
        }

        private void uprpol_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);

        }
    }
}
