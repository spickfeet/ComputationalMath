using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public interface IFunction
    {
        public double GetFunction(double x);
        public double GetDerivativeFunction(double x);
    }
}
