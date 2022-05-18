using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuzinaMarathphon.MarathonSkills2022_2DataSetTableAdapters;
using static ZuzinaMarathphon.MarathonSkills2022_2DataSet;

namespace ZuzinaMarathphon
{
    public partial class myspon : Form
    {
        public myspon()
        {
            InitializeComponent();
        }

        //UserTableAdapter userTableAdaptor = new UserTableAdapter();
        //RunnerTableAdapter runnerTableAdaptor = new RunnerTableAdapter();
        //RegistrationTableAdapter registrationTableAdaptor = new RegistrationTableAdapter();

        private void myspon_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathonSkills2022_2DataSet.Charity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Registration". При необходимости она может быть перемещена или удалена.
            this.registrationTableAdapter.Fill(this.marathonSkills2022_2DataSet.Registration);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.marathonSkills2022_2DataSet.Runner);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathonSkills2022_2DataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkills2022_2DataSet.Sponsorship". При необходимости она может быть перемещена или удалена.
            this.sponsorshipTableAdapter.Fill(this.marathonSkills2022_2DataSet.Sponsorship);

            decimal totalDonations = marathonSkills2022_2DataSet
                .Sponsorship
                .Where(row => row.RegistrationRow.RunnerRow.UserRow.Email == login.LoginMail)
                .Select(row => row.Amount)
                .Sum();
            label13.Text = $"${(int)totalDonations}";

            SponsorshipRow[] topSponsors = marathonSkills2022_2DataSet
                .Sponsorship
                .Where(row => row.RegistrationRow.RunnerRow.UserRow.Email == login.LoginMail)
                .OrderByDescending(row => row.Amount)
                .Take(5)
                .ToArray();
            sponName1.Text = topSponsors.ElementAtOrDefault(0)?.SponsorName;
            sponName2.Text = topSponsors.ElementAtOrDefault(1)?.SponsorName;
            sponName3.Text = topSponsors.ElementAtOrDefault(2)?.SponsorName;
            sponName4.Text = topSponsors.ElementAtOrDefault(3)?.SponsorName;
            sponName5.Text = topSponsors.ElementAtOrDefault(4)?.SponsorName;

            sponSum1.Text = $"${topSponsors.ElementAtOrDefault(0)?.Amount}";
            sponSum2.Text = $"${topSponsors.ElementAtOrDefault(1)?.Amount}";
            sponSum3.Text = $"${topSponsors.ElementAtOrDefault(2)?.Amount}";
            sponSum4.Text = $"${topSponsors.ElementAtOrDefault(3)?.Amount}";
            sponSum5.Text = $"${topSponsors.ElementAtOrDefault(4)?.Amount}";


            blagorg.Text = marathonSkills2022_2DataSet
                .User
                .FindByEmail(login.LoginMail)
                .GetRunnerRows()
                .FirstOrDefault()
                .GetRegistrationRows()
                .FirstOrDefault()
                .CharityRow
                .CharityName;

            label5.Text = marathonSkills2022_2DataSet
                .User
                .FindByEmail(login.LoginMail)
                .GetRunnerRows()
                .FirstOrDefault()
                .GetRegistrationRows()
                .FirstOrDefault()
                .CharityRow
                .CharityDescription;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainscreen = new mainscreen();
            mainscreen.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sponsorshipTableAdapter.FillBy(this.marathonSkills2022_2DataSet.Sponsorship);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sponsorshipDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
