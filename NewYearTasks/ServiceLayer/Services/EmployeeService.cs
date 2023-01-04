using DomainLayer;
using DomainLayer.Models;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        double empSalary = 2000;
        public int GetEmployeeCount(DateTime startDate, DateTime endDate, double salary)
        {
            var employess = GetAll();
            int count = 0;
            foreach (var item in employess)
            {
                if (item.Birhtday > startDate && item.Birhtday < endDate && item.Salary > empSalary)
                {
                    count++;
                }
            }
            return count;
            
        }
        private Employee[] GetAll()
        {
            Employee c1 = new Employee
            {
                
                Name = "Shaiq",
                Surname = "Kazimov",
                Birhtday= new DateTime(1990,08,12),
                Salary=2500,
               
            };
            Employee c2 = new Employee
            {
                Name = "Haqqverdi",
                Surname = "Kazimov",
                Birhtday = new DateTime(1993, 05, 11),
                Salary = 2300,

            };
            Employee c3 = new Employee
            {
                
                Name = "Aqshin",
                Surname = "Hummetov",
                Birhtday = new DateTime(1999, 08, 11),
                Salary = 2300,


            };
            Employee c4 = new Employee
            {
                
                Name = "Jale",
                Surname = "Abdullayeva",
                Birhtday = new DateTime(2005, 05, 11),
                Salary = 2300,

            };
            Employee[] employees = { c1, c2, c3, c4 };
            return employees;
        }
    }
}
