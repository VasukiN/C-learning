using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_sample
{
    class Program
    {
       public static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenNumbercalculate(30);
            Program.Add(10, 20);
        }
        //return type is void and called without static modofier 
        public void EvenNumbercalculate(int Target)
        {
            int start = 0;
            while (start < Target)
            {
                start = start + 2;
                Console.WriteLine(start);
            }
        }
        /* Started to find the missing numbers couldn't get it 
            public void MissingNumber(int[] total)
            {
            Console.WriteLine("Enter the set of numbers");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the numbers to find missing");
            int number = int.Parse(Console.ReadLine());
            while(number!=total)
            {
                Console
            }
            */

        public static int Add(int FN,int SN)
        {

            return (FN+SN);
        }

    }
        
 }

