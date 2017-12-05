using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public class Reverse
    {
        public void FindingReverseNum()
        {
            int[] a = new int[10];
            Console.WriteLine("Please enter the number");
            for (int i=0;i<a.Length;i++)
            {
                Console.ReadLine();
            }
            for(int j=0;j<a.Length;j--)
            {
                Console.WriteLine("Reversed Number as follows:{0}",a[j]);
                Console.ReadLine();
            }
        }
    }
}
