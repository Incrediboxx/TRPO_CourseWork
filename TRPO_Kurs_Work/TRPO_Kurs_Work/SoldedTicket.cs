using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public class Ticket
    {
        int idTicket;
        Session session;
        int[] plase = new int[2];

        Ticket (int n,Session session,int[] plase)
        {
            this.idTicket = n;
            this.session = session;
            this.plase = plase;            
        }
        public int GetId()
        {
            return idTicket;
        }

        public Session GetSession()
        {
            return session;
        }

        public int[] GetPlase()
        {
            return plase;
        }



    }
    public class SoldedTicket
    {
        Dictionary<int, Ticket> tickedStorage = new Dictionary<int, Ticket>();

        public bool AddSession(Ticket ticket)
        {
            if (!tickedStorage.ContainsKey(ticket.GetId()))
            {
                tickedStorage.Add(ticket.GetId(), ticket);
                return true;
            }
            else
            {
                MessageBox.Show("Такой билет уже добавлен",
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
}
