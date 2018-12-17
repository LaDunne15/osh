using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проекта
{
    class Account
    {
        public string Nick;
        public string Login;
        public string password;
        public Account(string Nic,string Log,string pass)
        {
            Nick = Nic;
            Login = Log;
            password = pass;
        }
    }

}
