using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public class Hall
    {
        int idHall;
        int Capacity;
        bool[,] Places;

        public Hall(int idHall,int col,int row)
        {
            this.idHall = idHall;
            this.Capacity = col * row;
            this.Places = new bool[col,row];
        }

        public int GetId()
        {
            return idHall;
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public bool[,] GetPlaces()
        {
            return Places;
        }

        public bool FreePlace(int col,int row)
        {
            return Places[col, row];
        }

        public bool TakethePlace(int col, int row)
        {
            if (!Places[col, row])
            {
                Places[col, row] = true;
                return true;
            }
            else
            {
                MessageBox.Show("Данное место занято",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }
    }

    public class HallStorage
    {
        Dictionary<int, Hall> hallStorage = new Dictionary<int, Hall>();

        public bool AddHall(Hall hall)
        {
            if (!hallStorage.ContainsKey(hall.GetId()))
            {
                hallStorage.Add(hall.GetId(), hall);
                return true;
            }
            else
            {
                MessageBox.Show("Такой зал уже добавлен",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }

        public IDictionary<int, Hall> GetStorage()
        {
            return hallStorage;
        }
    }
}
