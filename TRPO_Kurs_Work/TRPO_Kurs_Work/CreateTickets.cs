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
    public partial class CreateTickets : Form
    {
        public CreateTickets(Session session)
        {
            InitializeComponent();
            Hall hall = DataBase.hallStorage.GetStorage()[session.GetHall()];

            label5.Text = session.GetFilm().GetName();
            label6.Text = session.GetFilm().GetDuration().ToString();
            label7.Text = hall.GetId().ToString();
            label8.Text = session.GetPrice().ToString();

            Button[,] button = new Button[hall.GetCol(),hall.GetRow()];
            

            int X = 15;
            int Y = 120;

            

            for (int i =0;i< hall.GetCol();i++)
                for (int j = 0; j < hall.GetRow(); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Text = "";
                    button[i, j].Width = 20;
                    button[i, j].Height = 20;
                    button[i, j].Visible = true;

                    if (hall.GetPlaces()[i, j])
                        button[i,j].BackColor = Color.Red;
                    else
                        button[i, j].BackColor = Color.Green;

                    button[i, j].Location = new Point(X + 22 * j + 2, Y + 22 * i );

                    this.Controls.Add(button[i, j]);
                }

        }
    }
}
