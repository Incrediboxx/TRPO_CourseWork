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
    public partial class AdminModeForm : Form
    {
        void LoadGrid1()
        {
            List<Film> list = new List<Film>(DataBase.filmStorage.GetStorage().Values);
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add(list[i].GetName(),
                                       list[i].GetDuration());
            }
        }

        void LoadGrid2()
        {
            List<Hall> list = new List<Hall>(DataBase.hallStorage.GetStorage().Values);
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView2.Rows.Add(list[i].GetId(),
                                       list[i].GetCapacity(),
                                       list[i].GetCol(),
                                       list[i].GetRow());
            }
        }

        void LoadGrid3()
        {
            List<Session> list = new List<Session>(DataBase.sessionStorage.GetStorage().Values);
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView3.Rows.Add(list[i].GetFilm().GetName(),
                                       list[i].GetFilm().GetDuration(),
                                       list[i].GetHall(),
                                       list[i].GetPrice());
            }
        }

        public AdminModeForm()
        {
            InitializeComponent();
            
        }

        private void AdminModeForm_Load(object sender, EventArgs e)
        {
            LoadGrid1();
            LoadGrid2();
            LoadGrid3();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.filmStorage.GetStorage().Clear();
            DataBase.hallStorage.GetStorage().Clear();
            DataBase.sessionStorage.GetStorage().Clear();
            
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
                DataBase.filmStorage.AddFilm(new Film(dataGridView1[0,i].Value.ToString(), Convert.ToInt32(dataGridView1[1,i].Value)));

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                DataBase.hallStorage.AddHall(new Hall(Convert.ToInt32(dataGridView2[0,i].Value), Convert.ToInt32(dataGridView2[1,i].Value), Convert.ToInt32(dataGridView2[2,i].Value)));

            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
                DataBase.sessionStorage.AddSession(new Session(i, new Film(dataGridView3[0,i].Value.ToString(), Convert.ToInt32(dataGridView3[1,i].Value)), Convert.ToInt32(dataGridView3[2,i].Value), Convert.ToInt32(dataGridView3[3,i].Value)));


        }
    }
}
