using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class FirstFunction : IFunction
    {
        public float GetFunction(float x)
        {
            return (float)(Math.Pow(x, 2) - 20 * Math.Sin(x) - 5);
        }
        public float GetDerivativeFunction(float x)
        {
            return 2 * x - 20 * (float)Math.Cos(x);
        }
    }
}
