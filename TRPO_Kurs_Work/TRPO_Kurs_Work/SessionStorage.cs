using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public class Session
    {
        int idSession;
        Film film;
        int hallId;
        int price;

        public Session(int n,Film film,int hallId,int price)
        {
            this.idSession = n;
            this.film = film;
            this.hallId = hallId;
            this.price = price;
        }

        public int GetId()
        {
            return idSession;
        }

        public Film GetFilm()
        {
            return film;
        }

        public int GetHall()
        {
            return hallId;
        }

        public int GetPrice()
        {
            return price;
        }
    }
    public class SessionStorage
    {
        Dictionary<int, Session> sessionStorage = new Dictionary<int, Session>();

        public bool AddSession(Session session)
        {
            if (!sessionStorage.ContainsKey(session.GetId()))
            {
                sessionStorage.Add(session.GetId(), session);
                return true;
            }
            else
            {
                MessageBox.Show("Такой сеанс уже добавлен",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }

        public IDictionary<int, Session> GetStorage()
        {
            return sessionStorage;
        }
    }
}
