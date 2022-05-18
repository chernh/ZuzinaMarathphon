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
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //переход к авторизации
        {
            Hide();
            Form login = new login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Proverka = new Proverka();
            Proverka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form spon = new spon();
            spon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form info = new info();
            info.Show();
        }

        VolunteerTableAdapter volunteerTable = new VolunteerTableAdapter();

        private void button5_Click(object sender, EventArgs e)
        {
            // Получаем данные (список строчек) из таблицы
            var volunteerData = volunteerTable.GetData();


            // Добавление новой строчки в таблицу
            //volunteerTable.Insert("Name", "Surname", "RUS", "Male");


            // начало сложной строки
            int rowsCount =
                volunteerData // В этой переменной хранится список всех строчек в таблиице
                .Count(); // эта команда считает длинну списка
            // конец сложной строки (;)

            // начало сложной строки
            int malesCount =
                volunteerData // описано выше
                .Where(row => (row.Gender == "Male"))
                // эта комманда создает новый список, в котором остаются только те строки, которые прошли по условию
                // Условие (row.Gender == "Male") может быть любым. row - название проверяемой строчки, Gender - название столбца
                .Count(); // описано выше
            // конец сложной строки (;)


            // Просто сложная строка, без переносов
            int femalesCount = volunteerData.Where(row => (row.Gender == "Female")).Count();


            // начало сложной строки
            VolunteerRow firstFound =
                volunteerData // описано выше
                .First(row => (row.FirstName == "Name5")); // Эта комманда выберает первую строку, подходящую по условию
            // конец сложной строки (;)


            MessageBox.Show(
                $"Всего волонтеров: {rowsCount}, из них {malesCount} - м, {femalesCount} - ж\n" +
                $"Пол первого волонтера с именем Name5: {firstFound.Gender}"
            );

            // начало сложной строки
            VolunteerRow[] maleRows =
                volunteerData // описано выше
                .Where(row => (row.Gender == "Male")) // описано выше
                .ToArray(); // Эта команда преобразует список строк в обычный массив строк
            // конец сложной строки (;)

            foreach (VolunteerRow row in maleRows)
            {
                MessageBox.Show(
                    $"Волонтер ID: {row.VolunteerId}, " + // поля VolunteerId, FirstName, LastName, CountryCode, Gender есть,
                    $"Name: {row.FirstName}, " +          //   потому что в таблице есть соответствующие столбцы
                    $"Surname: {row.LastName}, " +
                    $"CountryCode: {row.CountryCode}, " +
                    $"Gender: {row.Gender}"
                );
            }

            // Обновляем данные в БД
            volunteerTable.Update(volunteerData);
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            login.LoginMail = null;
        }
    }
}
