using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShiganovaAV.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 2 * x + 6;
                    double result = numerator / denominator - 3;

                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
