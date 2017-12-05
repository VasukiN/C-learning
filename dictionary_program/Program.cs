using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_program
{
    class Program
    {
        static void Main(string[] args)
        {
            customer cus1 = new customer()
            {
                ID = 1,
                name = "Vasuki",
                salary = 300000

            };
            customer cus2 = new customer()
            {
                ID = 2,
                name = "Supriya",
                salary = 20000
            };
            customer cus3 = new customer()
            {
                ID = 3,
                name = "Deeps",
                salary = 50000
            };

            Dictionary<int ,customer > dictionarycustomer = new Dictionary<int,customer>();
            dictionarycustomer.Add(cus1.ID, cus1);
            dictionarycustomer.Add(cus2.ID, cus2);
            dictionarycustomer.Add(cus3.ID, cus3);
            //customer Customer1 = dictionarycustomer[1];
            foreach(KeyValuePair<int,customer> keyvaluepairobjects in dictionarycustomer)
            {
                Console.WriteLine("KEY = {0}", keyvaluepairobjects.Key);
                customer custom = keyvaluepairobjects.Value;
                Console.WriteLine("ID = {0} NAME = {1} SALARY ={2}",custom.ID,custom.name,custom.salary);
                Console.WriteLine("----------------------------------------------------------------------");
                    
            }
            Console.ReadLine();
        }
    }
    public class customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
    }
}
