using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Kurs_Work
{
    class Client
    {
        String name;
        String phoneNumber;

        Client(String name,String phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public string getPhone()
        {
            return phoneNumber;
        }
    }
}
