using ServiceLayer.Services;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTasks.Controllers
{
    public class FibonacciController
    {
        public void Fibonacci()
        {
           FibonacciService fibonacciService = new FibonacciService();
            fibonacciService.Fibonacci(13);
        }
    }
   

}
