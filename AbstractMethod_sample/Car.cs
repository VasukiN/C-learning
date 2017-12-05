using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod_sample
{
    public  abstract class Car : Toyota 
    {
        private abstract double price();
        public abstract int GetToAllSeat();
        public abstract string color();
        public string wheel()
        {

            return "4 wheeler vehicle";

        }
        public string CheckAC()
        {

            return "Ac is available";

        }
        public string CallFacility()
        {

            return "Call Facility is available";


        }

    }
}
