using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_example
{
    public enum Gender
    {
        Unknown,
        Male,
        Females
    }

    public interface getmethod
    {
        void method();
    }
    public class customer :getmethod
    {
        public enum Engineer
        {
            Mechanical_Engineer,
            Computer_Engineer,
            Information_Engineer,
            Electrical_Engineer,
            Civil_Engineer

        }
       
        public string name { get; set; }
        public Gender gender { get; set; }
        void getmethod.method()
        {
            Engineer.Civil_Engineer=
        }
    }

    class Program
    {
        //public string name
        //{
        //    get { return name; }
        //    set { value = name; }
        //}
        //public string gender
        //{
        //    get { return gender; }
        //    set { value = gender; }
        //}
        
        static void Main(string[] args)
        {
            customer[] customer1 = new customer[3];
            customer1[0] = new customer
            {
                name = "Vasuki",

                gender = Gender.Females

            };
            customer1[1] = new customer
            {
                name = "Suppi", gender = Gender.Females
            };
            customer1[2] = new customer
            {
                name = "Dog", gender = Gender.Unknown
            };
            
            foreach(customer s in customer1)
            {
                Console.WriteLine("Customrer name: {0zdgh} and Customer gender : {1}", s.name, s.gender);
                Console.ReadLine();
            }
            
        }
        
        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "uknown";
                case Gender.Male:
                    return "Male";
                case Gender.Females:
                    return "Female";
                default:
                    return "Invalid detected";
                    

            }
        }
    }
}
