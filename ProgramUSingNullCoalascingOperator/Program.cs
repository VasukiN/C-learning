using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUSingNullCoalascingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? ticketsonsale = null;
            int availabletickets = ticketsonsale ?? 0;
            Console.WriteLine("Availbel tickets = {0}", availabletickets);
           
        }

    }
}
