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
    public partial class MainForm : Form
    {
        public void  LoadGrid()
        {
            List<Session> list = new List<Session>(DataBase.sessionStorage.GetStorage().Values);
            for (int i = 0; i < list.Count; i++) 
            {
                dataGridView1.Rows.Add(list[i].GetFilm().GetName(),
                                       list[i].GetFilm().GetDuration(),
                                       list[i].GetHall().GetId(),
                                       list[i].GetPrice());
            }
        }

        public MainForm()
        {
            
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            List<Session> list = new List<Session>(DataBase.sessionStorage.GetStorage().Values);
            Session buff = list[dataGridView1.SelectedCells[0].RowIndex];
            CreateTickets form = new CreateTickets(buff);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DataBase.currentClient.GetAdmin())
            {
                AdminLogin form = new AdminLogin();
                form.Show();
            }
        }
    }
}
