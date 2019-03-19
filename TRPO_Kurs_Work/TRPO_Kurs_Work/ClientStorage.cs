using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public class ClientStorage
    {
        Dictionary<string, Client> clientStorage = new Dictionary<string, Client>();



        public bool AddClient(Client client)
        {
            if (!clientStorage.ContainsKey(client.getPhone()))
            {
                clientStorage.Add(client.getPhone(), client);
                return true;
            }
            else
            {
                MessageBox.Show("Клиент с таким номером уже зарегестрирован",
                                "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly
                                );
                return false;
            }
        }

        public IDictionary<String, Client> GetStotage()
        {
            return clientStorage;
        }
        
    }
}
