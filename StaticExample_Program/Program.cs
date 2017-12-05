using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample_Program
{
    class sample
    {
         public int radius;
        public static float pi;// = 3.141f;
         public sample(int r1)
        {
            this.radius = r1;
        }
        public  float calculatearea()
        {
            return pi*radius*radius;
        }

    }
    class Program
    {
      static void Main(string[] args)
        {
            sample s1 = new sample(4);
            sample.pi = 3.142f; //static variable called upon on the class.
            float TotalArea = s1.calculatearea();
            Console.WriteLine("Area of the cirlce: {0}" , TotalArea);
            Console.ReadLine();
            
        }
    }
}
