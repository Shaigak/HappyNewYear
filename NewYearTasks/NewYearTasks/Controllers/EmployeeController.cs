using ServiceLayer.Services;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTasks.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _services;

        public EmployeeController()
        {
            _services = new EmployeeService();
        }
        public void GetEmployeeCount() => Console.WriteLine(_services.GetEmployeeCount(new DateTime(1992,01,12),new DateTime(2000,08,12),1700));
    }
}
