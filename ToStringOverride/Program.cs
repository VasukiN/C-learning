using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Program cs = new Program();
            Console.WriteLine("-------------Get Types of objects----------------");
            Console.WriteLine(cs.GetType().Assembly);
            Console.WriteLine(cs.GetType().AssemblyQualifiedName + " " + cs.GetType().CustomAttributes);
            Console.WriteLine("-------------Get strings of objects----------------");
            Console.WriteLine(cs.ToString());
            Console.ReadLine();
        }
    }
}
