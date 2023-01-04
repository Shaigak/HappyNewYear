using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interaces
{
    public interface IEmployeeService
    {
        int GetEmployeeCount(DateTime startDate, DateTime endDate,double salary);
    }
}

