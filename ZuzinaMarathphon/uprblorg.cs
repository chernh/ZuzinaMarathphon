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
    public partial class uprblorg : Form
    {
        public uprblorg()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new redblag().Show();
        }

        private void uprblorg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathonSkills2022_2DataSet.Charity);

        }
    }
}
