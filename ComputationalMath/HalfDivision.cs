using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class HalfDivision
    {
        float accuracy = (float)Math.Pow(10, -5);
        public void InitAccuracy(float ac)
        {
            accuracy = ac;
        }
        public float DoMethod(float a, float b, IFunction f)
        {
            float answer = 1;
            while (Math.Abs(a - b) > accuracy)  //пока длина заданного интервала больше точности
            {
                float middle = (a + b) / 2;
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
