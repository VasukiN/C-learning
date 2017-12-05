using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingonList
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
            List<customer> ListCustomer = new List<customer>();
            ListCustomer.Add(cus1);
            ListCustomer.Add(cus2);
            ListCustomer.Add(cus3);
            //customer objscts = List<customer> Listob;
            ListCustomer.Sort();
            Comparison < customer > customercompare = new Comparison<customer>(ConsumerCompare);
            Console.WriteLine("Customer id before sorting");
            foreach(customer customer in ListCustomer)
            {
                Console.WriteLine(customer.ID); 
            }
            ListCustomer.Sort(customercompare);
            //Comparison<customer> customercompare = new Comparison<customer>(ConsumerCompare);
            Console.WriteLine("Customer id after sorting");
            foreach (customer customer in ListCustomer)
            {
                Console.WriteLine(customer.ID);
            }
        }
        public static int ConsumerCompare(customer T,customer Y)
        {
            return T.ID.CompareTo(Y.ID);
        }
    }
    
    public class customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
    }
}
