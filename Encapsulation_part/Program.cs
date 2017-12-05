using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Encapsulation_part
{
    public class Supriya 
    {
        public int age; // variables 
        public string name;
        public string technology;

        protected void Callingmethod() //method 
        {
            Console.WriteLine("Hi"+" "+ name + " , " + "Welocme to Bangalore" + " " +"MY Age is "+" "+ age +" "+"Learning " + technology+ "Language");
            Console.ReadLine();
        }
        public void Callingmethod2() //method 
        {
            Console.WriteLine("Hi" + " " + name + " , " + "Welocme to Bangalore" + " " + "MY Age is " + " " + age + " " + "Learning " + technology + "Language");
            Console.ReadLine();
        }
    }
    class Program : Supriya
    {

        static void Main(string[] args)
        {
            // Proetected definition to display
            Program s1 = new Program();
            s1.age = 23;
            s1.name = "Suppi";
            s1.technology = ".NET C#";
            s1.Callingmethod();

            // public definition to display
            Supriya s2 = new Supriya();
            s2.age = 25;
            s2.name = "Vasuki";
            s2.technology = ".NET C#";
            s2.Callingmethod2();
            //s1.Callingmethod();

        }
    }
}
