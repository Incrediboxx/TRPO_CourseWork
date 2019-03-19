using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TRPO_Kurs_Work
{
    class ClientStorage
    {
        private static ClientStorage storage;        
        ClientStorage()
        {}
        public static ClientStorage getStorage()
        {
            if (storage == null)
                storage = new ClientStorage();
            return storage;
        }

        IDictionary<String, Client> clientStorage = new Dictionary<String, Client>();

        void PutClient(Client client)
        {
            if (!clientStorage.ContainsKey(client.getPhone()))
                clientStorage.Add(client.getPhone(), client);
        }

        IDictionary<String, Client> GetStotage()
        {
            return clientStorage;
        }
        
    }
}
