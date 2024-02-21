using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComputationalMath
{
    public class SimpleIteration
    {
        public float Accuracy { get; set; } = (float)Math.Pow(10,-6);
        public float GetAccuracy(float q, float e)
        {
            return (q - 1) / q * e;
        }
        public float DoMethod(float a, IFunction function, List<float> intermediateValue)
        {
            switch (a)
            {
                case -5:
                    throw new ArgumentException("Для данного отрезка метод не применим");
                case -4:
                    return GetAnswer(a, GetAccuracy(0.6327f, Accuracy), -1/13.817f, function, intermediateValue);

                case -1:
                    return GetAnswer(a, Accuracy, 1/19.174f, function, intermediateValue);

                case 2:
                    return GetAnswer(a, GetAccuracy(0.5219f, Accuracy), -1/25.8f, function, intermediateValue);
                case 99:
                    return GetAnswer(a, Accuracy, -9.8f * (float)Math.Pow(10,-5), function, intermediateValue);
            }
            return 0;
        }
        public float GetAnswer(float a, float accuracy, float lambda, IFunction function, List<float> intermediateValue)
        {
            float xN = a;
            float xN1;
            while (true)
            {
                xN1 = xN + lambda * function.GetFunction(xN);

                if (Math.Abs(xN - xN1) <= Math.Abs(accuracy))
                {
                    return xN1;
                }
                xN = xN1;
                intermediateValue.Add(xN);
            }
        }
    }  
}
