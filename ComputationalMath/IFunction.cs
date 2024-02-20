using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public interface IFunction
    {
        public float GetFunction(float x);
        public float GetDerivativeFunction(float x);
    }
}
