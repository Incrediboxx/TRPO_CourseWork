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
        bool Admin;

        Client(String name,String phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        bool Login(string password)
        {
            if (password == "112233")
                this.Admin = true;
            return Admin;
        }

        public string getPhone()
        {
            return phoneNumber;
        }

        public string getName()
        {
            return name;
        }
    }    
}
