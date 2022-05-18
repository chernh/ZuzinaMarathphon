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
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
            panel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Finish";
            label2.Visible = true;
            label2.Text = "Final";
            label9.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;


            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Race Start";
            label2.Visible = true;
            label2.Text = "Samba Full Marathon";
            label9.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;


            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Race Start";
            label2.Visible = true;
            label2.Text = "Jongo Half Marathon";
            label9.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;

            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Race Start";
            label2.Visible = true;
            label2.Text = "Capoeira 5km Fun Run";
            label9.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;

            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;


        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 1";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Avenida Rudge";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = false;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            label1.Text = "Checkpoint 2";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Theatro Municipal";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = true;
            label4.Text = "Medical";
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = true;
            label6.Text = "Information";
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 3";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Parque do Ibirapuera";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = false;
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 4";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Jardim Luzitania";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = true;
            label4.Text = "Medical";
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = false;
            label6.Text = "Information";
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 5";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Iguatemi";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = false;
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = true;
            label6.Text = "Information";
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 6";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Rua Lisboa";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = false;
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = false;
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 7";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Cemitério da Consolação";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = true;
            label4.Text = "Medical";
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = true;
            label6.Text = "Information";
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Checkpoint 8";
            label2.Visible = true;
            label2.Text = "Landmark";
            label8.Visible = true;
            label8.Text = "Cemitério da Consolação";
            label9.Visible = true;
            label9.Text = "Services Provided";
            label3.Visible = true;
            label3.Text = "Toilets";
            label4.Visible = true;
            label4.Text = "Medical";
            label5.Visible = true;
            label5.Text = "Energy Bars";
            label6.Visible = true;
            label6.Text = "Information";
            label7.Visible = true;
            label7.Text = "Drinks";
            panel1.Visible = true;

            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form about = new about();
            about.Show();
        }
    }
}
