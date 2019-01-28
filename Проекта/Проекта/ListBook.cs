using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проекта
{
    class ListBook
    {
        public List<Book> Lista = new List<Book> { };//список книг
        public ListBook ()
        {

        }
        public ListBook (List<Book> A)//просвоэння списку книг
        {
            foreach(Book i in A)
            {
                Lista.Add(i);
            }
        }
        public void AddBook(Book A)//додати книгу
        {
            Lista.Add(A);
        }
        public List<Book> OneTypeBooks(int g)//повертає список книг із визначеним жанром
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
        public int cou (int g)//повертає кількість книг із визначеним жанром
        {
            int j = 0;
            List<Book> A = new List<Book> { };
            foreach (Book i in Lista)
            {
                if (i.Genre == g)
                {
                    j++;
                }
            }
            return j;
        }

    }
}
