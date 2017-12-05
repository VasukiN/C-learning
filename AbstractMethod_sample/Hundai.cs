using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod_sample
{
    public sealed class Hundai : Car
    {
        public override double price()
        {
            return 123222.450;
        }
        public override int GetToAllSeat()
        {
            return 6;
        }
        public override string color()
        {
            return "maroon";
        }
       
    }
    
}
