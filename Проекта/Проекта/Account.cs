using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проекта
{
    class Account
    {
        public string Nick;//Нік співробітника
        public string Login;//Логін співробітника
        public string password;//пароль співробітника
        public Account(string Nic,string Log,string pass)
        {
            Nick = Nic;
            Login = Log;
            password = pass;
        }
        public Account(Account l)
        {
            this.Nick = l.Nick;
            this.Login = l.Login;
            this.password = l.password;
        }
        public void ChangePass(string A)
        {
            password = A;
        }
        public void ChangeLogin(string A)
        {
            Login = A;
        }
    }

}
