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
    public partial class regmar : Form
    {
        public regmar()
        {
            InitializeComponent();
            panel3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new menu().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            Hide();
            new menu().Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            decimal sum = 0;

            if (checkBox1.Checked)
                sum += 145;

            if (checkBox2.Checked)
                sum += 75;

            if (checkBox3.Checked)
                sum += 20;

            string kitOption = "A";

            if (radioButton2.Checked)
            {
                sum += 20;
                kitOption = "B";
            }
            if (radioButton3.Checked)
            {
                sum += 45;
                kitOption = "C";
            }

            var runnerId = marathonSkills2022_2DataSet
                    .User
                    .FindByEmail(login.LoginMail)
                    .GetRunnerRows()
                    .First()
                    .RunnerId;

            var charityId = marathonSkills2022_2DataSet
                    .Charity
                    .First(row => row.CharityName == comboBox1.Text)
                    .CharityId;

            this.registrationTableAdapter.Insert(
                runnerId, 
                DateTime.Now, 
                kitOption, 
                1,
                Convert.ToDecimal(textBox5.Text), 
                charityId, 
                sum
            );

            Form podregbeg = new podregbeg();
            podregbeg.Show();
        }

        private void charityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.charityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marathonSkills2022_2DataSet);

        }

        private void regmar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.marathonSkills2022_2DataSet.Registration);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathonSkills2022_2DataSet.Charity);

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(marathonSkills2022_2DataSet.Charity.Select(row => row.CharityName).ToArray());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int sum = 0;
            if (checkBox1.Checked)
                sum += 145;
            if (checkBox2.Checked)
                sum += 75;
            if (checkBox3.Checked)
                sum += 20;

            if (radioButton2.Checked)
                sum += 20;
            if (radioButton3.Checked)
                sum += 45;

            label11.Text = $"${sum}";
        }
    }
}
