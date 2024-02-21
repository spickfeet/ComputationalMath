using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMath
{
    public class HalfDivision
    {
        private float _accuracy = (float)Math.Pow(10, -5);
        public float Accuracy
        {
            get { return _accuracy; }
            set { _accuracy = value; }
        }
        public float DoMethod(float a, float b, IFunction f, List<float> intermediateValue)
        {
            float answer = 1;
            while (true)  //пока длина заданного интервала больше точности
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
                if(Math.Abs(a - b) < Accuracy)
                {
                    return answer;
                }
                intermediateValue.Add(answer);
            }
        }
    }
}
