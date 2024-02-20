using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class HalfDivision
    {
        double accuracy = Math.Pow(10, -15);
        public void InitAccuracy(double ac)
        {
            accuracy = ac;
        }
        public double DoMethod(double a, double b, IFunction f)
        {
            double answer = 1;
            while (Math.Abs(a - b) > accuracy)  //пока длина заданного интервала больше точности
            {
                double middle = (a + b) / 2;
                if (f.GetFunction(middle) == 0)
                {
                    answer = middle;
                    return answer;
                }
                else
                {
                    answer = middle;
                    if (f.GetFunction(middle) * f.GetFunction(a) < 0)
                    {
                        b = middle;

                    }
                    else
                    {
                        a = middle;
                    }
                }
            }
            return answer;
        }
    }
}
