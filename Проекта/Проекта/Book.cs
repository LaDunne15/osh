using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проекта
{
    class Book
    {
        public string Name,Author;
        public double price;
        public string About;
        public int Genre;
        public Book (string A,string B,double C,string D,int E)
        {
            Name = A;
            Author = B;
            price = C;
            About = D;
            Genre = E;
        }
    }
}
