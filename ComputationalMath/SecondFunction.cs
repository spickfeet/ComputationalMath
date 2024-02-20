using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class SecondFunction : IFunction
    {
        public double GetFunction(double x/*, double y*/)
        {
            return 100 * Math.Pow(x, 2) - 10000 * x - 1;
        }
        public double GetDerivativeFunction(double x)
        {
            return 200 * x - 10000;
        }
    }
}
