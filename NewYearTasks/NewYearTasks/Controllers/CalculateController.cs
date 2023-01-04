using ServiceLayer.Services;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTasks.Controllers
{
    public class CalculateController
    {
        public void Calculate()
        {
            Console.WriteLine("Birinci reqemi daxil edin ");
            float n=float.Parse(Console.ReadLine());
            Console.WriteLine("Operatoru daxil edin ");
            string operate=Console.ReadLine();
            Console.WriteLine("Ikinci reqemi daxil edin");
            float m=float.Parse(Console.ReadLine());
            ICalculateService calculateservice = new CalculateService();
            var result = calculateservice.Calculate(n, m, operate);
            Console.WriteLine($"Netice:{result}");

        }
    }
}
