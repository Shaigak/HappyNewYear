using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public float Calculate(float n, float m, string operate)
        {
            float result = 0;
            switch (operate)
            {
                case "+":
                    result = n + m;
                    break;

                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
            }
            return result;
        }
    }
}
