using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class NewtonMethod
    {
        private float _accuracy = (float)Math.Pow(10, -5);
        public float FindSolution(int a, IFunction function)
        {
            float x1 = a;
            float x2;
            while (true)
            {
                x2 = x1 - function.GetFunction(x1) /
                    function.GetDerivativeFunction(x1); // производная
                if (Math.Abs(x1 - x2) < _accuracy)
                {
                    return x2;
                }
                x1 = x2;
            }
        }
    }
}
