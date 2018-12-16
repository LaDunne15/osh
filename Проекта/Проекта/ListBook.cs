using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проекта
{
    class ListBook
    {
        public List<Book> Lista = new List<Book> { };
        public ListBook ()
        {

        }
        public ListBook (List<Book> A)
        {
            foreach(Book i in A)
            {
                Lista.Add(i);
            }
        }
        public void AddBook(Book A)
        {
            Lista.Add(A);
        }
        public List<Book> OneTypeBooks(int g)
        {
            List<Book> A = new List<Book> { };
            foreach(Book i in Lista)
            {
                if(i.Genre==g)
                {
                    A.Add(i);
                }
            }
            return A;
        }
        public int cou (int g)
        {
            List<Book> A = new List<Book> { };
            foreach (Book i in Lista)
            {
                if (i.Genre == g)
                {
                    A.Add(i);
                }
            }
            return A.Count;
        }

    }
}
