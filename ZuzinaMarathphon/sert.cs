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
    public partial class sert : Form
    {
        public sert()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new redpb().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void sert_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.marathonSkills2022_2DataSet.Event);

        }
    }
}
