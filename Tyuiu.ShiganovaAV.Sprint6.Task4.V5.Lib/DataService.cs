using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShiganovaAV.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("Стартовое значение не может быть больше конечного");
            }

            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                double denominator = 3 * x + 1.2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    resultArray[i] = 0;
                }
                else
                {
                    double value = (2 * Math.Sin(x)) / denominator + Math.Cos(x) - 14 * x;
                    resultArray[i] = Math.Round(value, 2);
                }
            }

            return resultArray;
        }
    }
}
