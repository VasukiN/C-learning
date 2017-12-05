using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateObjects_sample
{
    delegate bool IsPramote(Employee emp);

      class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int Experience { get; set; }

     public static  void PromoteEmployee(List<Employee> EmployeeList,IsPramote ISEligibleToPromote)
        {
            foreach(Employee employee in EmployeeList)
            {
                if(ISEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.name + " " + "promoted");
                    
                }
            }
            Console.ReadLine();
        }
    }
    class Program
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 1,name="Vasuki",salary=20000,Experience=3 });
            emplist.Add(new Employee() { ID = 2, name = "Deepa", salary = 50000, Experience = 6 });
            emplist.Add(new Employee() { ID = 3, name = "Divya", salary = 30000, Experience = 4 });
            emplist.Add(new Employee() { ID = 4, name = "Gauthami", salary = 60000, Experience = 7 });

            //IsPramote IsPromotable = new IsPramote(Pramote);
            Employee.PromoteEmployee(emplist,emp =>emp.salary>=5);  //using lambda ex[ression 

            }
        //public static bool Pramote(Employee emp)  //it is using delegate function
        //{
        //    if (emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;




        //}
    }
}
