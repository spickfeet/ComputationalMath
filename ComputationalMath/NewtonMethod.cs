using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class NewtonMethod
    {
        private double _accuracy = Math.Pow(10, -24);
        public double FindSolution(int a, IFunction function)
        {
            double x1 = a;
            double x2;
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
