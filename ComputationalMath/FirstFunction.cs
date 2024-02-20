using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class FirstFunction : IFunction
    {
        public double GetFunction(double x/*, double y*/)
        {
            return Math.Pow(x, 2) - 20 * Math.Sin(x) - 5;
        }
        public double GetDerivativeFunction(double x)
        {
            return 2 * x - 20 * Math.Cos(x);
        }
    }
}
