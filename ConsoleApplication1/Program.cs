using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties_example;

namespace ConsoleApplication1
{
    class Program:Library
    {
        static void Main(string[] args)
        {
            Library l1 = new Library();
            l1.BookVeriety();
            l1.BookExibition();
        }
    }
}
