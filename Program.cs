using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchstatementwithgoto
{
    class Program
    {
        static void Main(string[] args)
        {
            label1:
            Console.WriteLine("Enter your choice 1: Small 2: Medium 3: Large");
            int userinput = Convert.ToInt32(Console.ReadLine());//Convert.ToString((Console.ReadLine();)
            int Amounttobepaid = 0;
            switch(userinput)
            {
                case 1:
                    Console.WriteLine("Your coffe choice is Smaall");
                    Amounttobepaid += 1;
                    break;
                case 2:
                    Console.WriteLine("Your coffe choice is Medium");
                    Amounttobepaid += 2;
                    break;
                case 3:
                    Console.WriteLine("Your coffe choice is Large0");
                    Amounttobepaid += 3;
                    break;
                default:
                    Console.WriteLine("You have not entered correct choice");
                    goto label1;
            }
            Console.WriteLine("Do ypu want shop more ? Yes or No");
            string userchoice = Console.ReadLine();
            switch(userchoice)
            {
                case "Yes":
                    goto label1;
                case "No":
                    Console.WriteLine("Thanks for shopping with us");
                    break;
                default:
                    Console.WriteLine("Your choice is invlid");
                    break;

            }
            Console.WriteLine("Thanks for shopping with us");
            Console.WriteLine("Your Bill: {0}", Amounttobepaid);
        }
    }
}
