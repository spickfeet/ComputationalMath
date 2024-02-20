using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class SecondFunction : IFunction
    {
        public float GetFunction(float x/*, float y*/)
        {
            return 100 * (float)Math.Pow(x, 2) - 10000 * x - 1;
        }
        public float GetDerivativeFunction(float x)
        {
            return 200 * x - 10000;
        }
    }
}
