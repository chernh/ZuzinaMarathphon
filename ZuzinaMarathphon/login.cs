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

namespace ZuzinaMarathphon
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e) //скрытие панели
        {
            panel3.Visible = !panel3.Visible;
        }


        /*
        private void button2_Click(object sender, EventArgs e) //открытие панели
        {
            //panel3.Visible = true;
        }
        */

        UserTableAdapter userTableAdapter = new UserTableAdapter(); // Подключаем таблицу к форме

        public static string LoginMail = null;

        private void button2_Click(object sender, EventArgs e)
        {
            var userData = userTableAdapter.GetData(); // Получаем данные из таблицы

            var curUser = userData.FindByEmail(textBox1.Text.Trim()); // Получаем строку пользователя по почте (или null, если email не найден)
            
            if (curUser is null) // Если не найден email
            {
                MessageBox.Show($"Неверная почта!");
                return;
            }
            
            if (curUser.Password != textBox2.Text) // Если пароль не совпадает
            {
                MessageBox.Show($"Неверный пароль!");
                return;
            }
            
            // При успешном логине записываем почту вошедшего пользователя в публичную (доступную из других форм) переменную
            LoginMail = curUser.Email; 

            Hide(); // Скрываем форму
            MessageBox.Show($"Успешная авторизация! Ваша роль {curUser.RoleId}"); // Сообщаем о успешном входе

            // Открываем соответствующую роли форму
            if (curUser.RoleId == "R") {
                new menu().Show();
            } else if (curUser.RoleId == "C") {
                new menukoord().Show();
            } else if (curUser.RoleId == "A") {
                new menuadmin().Show();
            } else {
                MessageBox.Show("Неизвестная роль!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Hide();
            new mainscreen().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menukoord = new menukoord();
            menukoord.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form menuadmin = new menuadmin();
            menuadmin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new menu().Show();
        }
    }
}
