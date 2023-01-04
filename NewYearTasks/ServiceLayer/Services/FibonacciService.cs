using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public void Fibonacci(int n)
            {
                int a = 0, b = 1, c = 0;
                Console.Write ("{0} {1}", a, b);
                for (int i = 2; i <n; i++)
                {
                    c = a + b;
                    Console.Write( c);
                    a = b;
                    b = c;
                }
            }
        }
    }
    
