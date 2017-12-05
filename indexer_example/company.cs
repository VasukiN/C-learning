using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace indexer_example
{
    public class Employees
    {
        
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        
    }

    public class company 
    {

        // private List<string> Names;
        private List<Employees> EmployeeList;

        public company()
        {
            EmployeeList = new List<Employees>();
            EmployeeList.Add(new Employees { EmployeeId = 1, Name = "Vasuki", Gender = "Female" });
            EmployeeList.Add(new Employees { EmployeeId = 2, Name = "Deepa", Gender = "Female" });
            EmployeeList.Add(new Employees { EmployeeId = 3, Name = "ShreeHari", Gender = "Male" });
            EmployeeList.Add(new Employees { EmployeeId = 4, Name = "Pranav", Gender = "Male" });
            EmployeeList.Add(new Employees { EmployeeId = 5, Name = "Supriya", Gender = "Female" });
            EmployeeList.Add(new Employees { EmployeeId = 6, Name = "Nagashree", Gender = "Female" });
            EmployeeList.Add(new Employees { EmployeeId = 7, Name = "Raghu", Gender = "Male" });
            EmployeeList.Add(new Employees { EmployeeId = 8, Name = "Nagashree", Gender = "Female" });
            //Names.Add("Shree");
        }
        public string this[int employeeId]
        {
            get
            {
                return EmployeeList.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name + " "+" Gender"+" "+ EmployeeList.FirstOrDefault(emp => emp.EmployeeId == employeeId).Gender;
            }
            set
            {
                EmployeeList.FirstOrDefault(empa => empa.EmployeeId == employeeId).Name = value;
            }
        }
        public string this[string  gender]
        {
            get
            {

                return EmployeeList.Count(emp => emp.Gender == gender).ToString();
                    
                
            }
            set
            {
                foreach (Employees employe in EmployeeList)
                {
                    if (employe.Gender == gender)
                    {
                        employe.Gender = value;
                    }
    
                }
            }
        }
    }
}
