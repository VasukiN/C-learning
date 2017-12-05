using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
 
    
    class Program
    {
        int a = 10; int b = 20;
        public void  add(int a, int b, out int c)
        {
            c = a + b;
            Console.WriteLine("Sum of two numbers : {0}", c);
            Console.ReadLine();
        }
        public void add(float a, float b, out float c)
        {
            c = a + b;
            Console.WriteLine("Sum of two float numbers : {0}" ,c);
            Console.ReadLine();
        }

        public void add(int a, ref int b)
        {
            Console.WriteLine("Sum of two  numbers  using ref : {0}", a + b);
            Console.ReadLine();
        }
        public void add(int a,  int b)
        {
            a = 10; b = 20;
            Console.WriteLine("Sum of two  numbers  using ref : {0}", a + b);
            Console.ReadLine();
        }

        public void add(int a, int b , params int[] c)
        {
            a = 10; b = 20;
            Console.WriteLine("Sum of two  numbers  using ref : {0}", a + b);
            Console.ReadLine();
        }
        public void add(int a, int b, params int[] c)
        {
            a = 10; b = 20;
            Console.WriteLine("Sum of two  numbers  using ref : {0}", a + b);
            Console.ReadLine();
        }

        //public void add()
        //{
        //    c = a + b;
        //    Console.WriteLine(c);
        //}

        static void Main(string[] args)
        {
            int c;
            int e = 35;
            float d;
          
            {
                Program p1 = new Program();
                p1.add(2, 3,out c);
                p1.add(2.5f, 3.5f, out d);
                p1.add(30,ref e);
                p1.add(30,30);
                p1.add()
                //p1.add(2.3f, 3.4f,);
            }
        }

    }
}
