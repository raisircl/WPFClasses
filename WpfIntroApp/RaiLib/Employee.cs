using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntroApp.RaiLib
{
    public class Employee
    {
        public List<Employee> employees;
        public Employee()
        {
            
        }
        public List<Employee> GetEmployees()
        {
            employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name="Ram",Salary=50000},
                new Employee(){Id = 2, Name="Anil",Salary=5000},
                new Employee(){Id = 3, Name="Jatin",Salary=12000},
                new Employee(){Id = 4, Name="Kamal",Salary=30000},
                new Employee(){Id = 5, Name="Sunil",Salary=2000},
                new Employee(){Id = 6, Name="Ajay",Salary=1000},

            };
            return employees;
        }
        public int Id { get; set; }
        public string Name { get; set; } 
        public decimal Salary { get; set; }
    }
}
