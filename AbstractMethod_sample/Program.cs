using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod_sample
{
    
    class program
    {
        static void Main(string[] args)
        {
            Hundai c1 = new Hundai();
            Console.WriteLine("----------------HUNDAI CAR Specification-------------------------- ");
            Console.WriteLine(c1.wheel());
            Console.WriteLine(c1.CheckAC());
            Console.WriteLine(c1.CallFacility());
            Console.WriteLine("Total Price :{0} " ,c1.price());
            Console.WriteLine("Color of the CAr:{0} ", c1.color());
            Console.WriteLine("Seats availabilability: {0} ", c1.GetToAllSeat());
            Console.WriteLine("----------------TOYOTA CAR Specification--------------------------- ");
            Toyota c2 = new Toyota();
            Console.WriteLine(c2.wheel());
            Console.WriteLine(c2.CheckAC());
            Console.WriteLine(c2.CallFacility());
            Console.WriteLine(c2.DiscountPrice());
            Console.WriteLine("Total Price :{0} ",c2.price());
            Console.WriteLine("Color of the CAr:{0} ",c2.color());
            Console.WriteLine("Seats availabilability: {0} ",c2.GetToAllSeat());
            Console.ReadLine();
            
        }
    }
}
