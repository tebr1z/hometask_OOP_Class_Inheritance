using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class Account
    {

        public void Login (string username, string password)
        {
            if (username == "Admin" && password == "admin")
            {
                Console.WriteLine("Ugurlu girsh");
            }
            else {

                Console.WriteLine("isfadechi adi veya sifre yalnishdi");
            }
        }

    }
}
