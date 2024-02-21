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
        public float Accuracy 
        { 
            get { return _accuracy; }
            set { _accuracy = value; }
        }
        public float FindSolution(int a, IFunction function, List<float> intermediateValue)
        {
            float x1 = a;
            float x2;
            while (true)
            {
                x2 = x1 - function.GetFunction(x1) /
                    function.GetDerivativeFunction(x1); // производная
                if (Math.Abs(x1 - x2) < Accuracy)
                {
                    return x2;
                }
                x1 = x2;
                intermediateValue.Add(x1);
            }
        }
    }
}
