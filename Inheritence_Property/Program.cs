using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Property
{
    
    public class Employee
    {
        public string firstname;
        public string lastname;
        public Employee(string FN,String LN)
        {
            firstname = FN;
            lastname = LN ;
        }
        public void GetDataofEmployee()
        {
            Console.WriteLine("Employee Name:{0}",firstname + lastname);
            //Console.ReadLine();
        }
    }
    public class Employee2
        {
           public void GetDataofEmployee()
            {
            Console.WriteLine("Second Base Classs");
            }
        }
    public class fulltime : Employee2
    {
        public new void GetDataofEmployee()
        {
            Console.WriteLine("First Derived Class");
        }
    }
        public class partime : Employee2
        {

        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee("Hello","Welcome");
            emp.GetDataofEmployee();
            Employee2 emp1 = new Employee2();
                fulltime emp2 = new fulltime();
                partime emp3 = new partime();
                
                emp1.GetDataofEmployee();
                emp2.GetDataofEmployee();
                emp3.GetDataofEmployee();
            Console.ReadLine();
            }
        }
    }
