using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZuzinaMarathphon.MarathonSkills2022_2DataSet;

namespace ZuzinaMarathphon
{
    public partial class redpb : Form
    {
        public redpb()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }

        public static string RedactMail = null;

        private void button3_Click(object sender, EventArgs e)
        {
            UserRow user = this.marathonSkills2022_2DataSet.User.FindByEmail(RedactMail);

            user.FirstName = textBox4.Text;
            user.LastName = textBox5.Text;

            RunnerRow runner = user.GetRunnerRows().FirstOrDefault();

            runner.Gender = comboBox2.Text;
            runner.DateOfBirth = dateTimePicker1.Value;

            runner.CountryCode = marathonSkills2022_2DataSet.Country.FirstOrDefault(row => row.CountryName == comboBox1.Text).CountryCode;

            this.tableAdapterManager.UpdateAll(marathonSkills2022_2DataSet); 
            
            //Hide();
            //new uprbeg2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void redpb_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.marathonSkills2022_2DataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.RegistrationStatus". При необходимости она может быть перемещена или удалена.
            this.registrationStatusTableAdapter.Fill(this.marathonSkills2022_2DataSet.RegistrationStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.marathonSkills2022_2DataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Sponsorship". При необходимости она может быть перемещена или удалена.
            this.sponsorshipTableAdapter.Fill(this.marathonSkills2022_2DataSet.Sponsorship);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);

            UserRow user = this.marathonSkills2022_2DataSet.User.FindByEmail(RedactMail);

            label1.Text = user.Email;

            textBox4.Text = user.FirstName;
            textBox5.Text = user.LastName;

            RunnerRow runner = user.GetRunnerRows().FirstOrDefault();

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(marathonSkills2022_2DataSet.Gender.ToArray());

            comboBox2.Text = runner.Gender;
            dateTimePicker1.Value = runner.DateOfBirth;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(marathonSkills2022_2DataSet.Country.ToArray());

            comboBox1.Text = runner.CountryRow.CountryName;


            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(marathonSkills2022_2DataSet.RegistrationStatus.ToArray());

            try
            {
                comboBox3.Text = runner.GetRegistrationRows().FirstOrDefault().RegistrationStatusRow.RegistrationStatus;
            }
            catch { }
        }
    }
}
