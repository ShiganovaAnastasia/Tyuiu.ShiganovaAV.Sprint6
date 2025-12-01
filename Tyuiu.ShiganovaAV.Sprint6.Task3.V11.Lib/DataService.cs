using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] GetMatrix()
        {
            return new int[5, 5]
            {
                { 27, -15, 14,  2, 27 },
                { -8,  14, -10, 33,  0 },
                {  1,   7, -11, -11, 23 },
                { -13, -20, 15, -16, 34 },
                { -3,   1, -1,   5,  1 }
            };
        }

        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 0] > result[j, 0])
                    {
                        int temp = result[i, 0];
                        result[i, 0] = result[j, 0];
                        result[j, 0] = temp;
                    }
                }
            }

            return result;
        }
    }
}