using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace Проекта
{
    class ListAcc
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Proekta;Integrated Security=True";
        List<Account> l = new List<Account> { };
        public ListAcc(List<Account> f)
        {
            foreach (Account i in f)
                l.Add(i);
        }
        public ListAcc()
        {
            string c = "SELECT * FROM LOGIN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(c, connection);
                SqlDataReader DD = command.ExecuteReader();

                if (DD.HasRows)
                {
                    while (DD.Read())
                    {
                        object x1 = DD.GetValue(0);
                        object x2 = DD.GetValue(1);
                        object x3 = DD.GetValue(2);
                        l.Add(new Account(Convert.ToString(x1), Convert.ToString(x2), Convert.ToString(x3)));
                    }
                }
            }
        }
        public bool SearchAcc(string A,string B)
        {
            bool IsSearched=false;
            foreach(Account i in l)
                {
                if (i.Login.Replace(" ", "") == A && i.password.Replace(" ", "") == B)
                    IsSearched = true;
                }
            return IsSearched;
        }
        public void CHPass(string A,string B)
        {
            foreach(Account i in l)
                {
                if (i.password.Replace(" ", "") == A)
                    i.ChangePass(B);
            }
        }
        public void CHLogin(string A, string B)
        {
            foreach (Account i in l)
            {
                if (i.Login.Replace(" ", "") == A)
                    i.ChangeLogin(B);
            }
        }
    }
}
