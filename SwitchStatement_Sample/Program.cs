using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter valida number");
            int userinput = int.Parse(Console.ReadLine());
            switch(userinput)
            {
                case 10:
                    Console.WriteLine("Entered Number is TEN");
                    break;
                case 20:
                    Console.WriteLine("Entered Number is TWENTY");
                    break;
                default:
                    Console.WriteLine("You have not entered valida number");
                    break;
                       
            }

            Console.WriteLine("Enter valida number");
           int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 10:
                   
                case 20:
                case 30:
                    Console.WriteLine("Entered Number is TEN OR TWENTY OR THIRTY"); // yu can switch multiple statement at time 
                    break;
                default:
                    Console.WriteLine("You have not entered valida number");
                    break;

            }
        }

    }
}
