using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public partial class EnterForm : Form
    {
        void LoadData()
        {
            DataBase.filmStorage.AddFilm(new Film("Мстители", 120));
            DataBase.filmStorage.AddFilm(new Film("Гарри Поттер", 90));
            DataBase.filmStorage.AddFilm(new Film("Зелёная книга", 130));
            DataBase.filmStorage.AddFilm(new Film("Звёздные войны", 120));
            DataBase.filmStorage.AddFilm(new Film("Капитан Америка", 140));
            DataBase.filmStorage.AddFilm(new Film("Форсаж", 90));

            DataBase.hallStorage.AddHall(new Hall(1, 5, 6));
            DataBase.hallStorage.AddHall(new Hall(2, 5, 5));
            DataBase.hallStorage.AddHall(new Hall(3, 7, 4));
            DataBase.hallStorage.AddHall(new Hall(4, 10, 10));
            DataBase.hallStorage.AddHall(new Hall(5, 12, 8));
            DataBase.hallStorage.AddHall(new Hall(6, 12, 8));

            DataBase.sessionStorage.AddSession(new Session(1, DataBase.filmStorage.GetStorage()["Мстители"], DataBase.hallStorage.GetStorage()[1], 150));
            DataBase.sessionStorage.AddSession(new Session(2, DataBase.filmStorage.GetStorage()["Гарри Поттер"], DataBase.hallStorage.GetStorage()[2], 100));
            DataBase.sessionStorage.AddSession(new Session(3, DataBase.filmStorage.GetStorage()["Зелёная книга"], DataBase.hallStorage.GetStorage()[3], 123));
            DataBase.sessionStorage.AddSession(new Session(4, DataBase.filmStorage.GetStorage()["Капитан Америка"], DataBase.hallStorage.GetStorage()[4], 140));
            DataBase.sessionStorage.AddSession(new Session(5, DataBase.filmStorage.GetStorage()["Форсаж"], DataBase.hallStorage.GetStorage()[5], 100));
            DataBase.sessionStorage.AddSession(new Session(6, DataBase.filmStorage.GetStorage()["Мстители"], DataBase.hallStorage.GetStorage()[6], 150));

            DataBase.clientStorage.AddClient(new Client("Никита", "12"));
        }

        public EnterForm()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataBase.clientStorage.GetStotage().ContainsKey(textBox1.Text))
            {
                DataBase.currentClient = DataBase.clientStorage.GetStotage()[textBox1.Text];
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Такой клиент не зарегистрирован.Пройти регистрацию?",
                                                       "Ошибка",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information,
                                                        MessageBoxDefaultButton.Button1,
                                                        MessageBoxOptions.DefaultDesktopOnly
                                                      );

                if (result == DialogResult.Yes)
                {
                    Registration form = new Registration();
                    form.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Show();
        }
    }
}
