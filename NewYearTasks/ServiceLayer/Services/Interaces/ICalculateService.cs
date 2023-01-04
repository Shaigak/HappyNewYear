using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interaces
{
    public interface ICalculateService
    {
        float Calculate(float n, float m, string operate);
    }
}
