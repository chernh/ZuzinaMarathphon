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
    public partial class regbeg : Form
    {
        public regbeg()
        {
            InitializeComponent();
        }

        private void regbeg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form regmar = new regmar();
            regmar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            Hide();
            new mainscreen().Show();

        }
    }
}
