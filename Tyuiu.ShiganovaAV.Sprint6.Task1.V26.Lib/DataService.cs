using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShiganovaAV.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task1V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = 2 * x - 1;

                if (Math.Abs(denominator) < 0.0001)
                {
                    res[i] = 0;
                }
                else
                {
                    double fraction = (2 * Math.Cos(x) + 2) / denominator;
                    res[i] = Math.Round(fraction + Math.Cos(x) - 5 * x + 3, 2);
                }
            }

            return res;
        }
    }
}
