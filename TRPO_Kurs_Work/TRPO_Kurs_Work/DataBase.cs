using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Kurs_Work
{
    public class DataBase
    {
        public static FilmStorage filmStorage = new FilmStorage();
        public static ClientStorage clientStorage = new ClientStorage();
        public static HallStorage hallStorage = new HallStorage();
        public static SessionStorage sessionStorage = new SessionStorage();
        public static SoldedTicket soldedTicket = new SoldedTicket();
        public static Client currentClient = new Client();        
    }
}
