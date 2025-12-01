using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            // Копируем всю матрицу
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Просто берем все первые элементы и сортируем их
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 0] > result[j, 0])
                    {
                        // Меняем местами ТОЛЬКО первый элемент
                        int temp = result[i, 0];
                        result[i, 0] = result[j, 0];
                        result[j, 0] = temp;
                        // ВСЕ ОСТАЛЬНЫЕ ЭЛЕМЕНТЫ ОСТАЮТСЯ НА МЕСТЕ!
                    }
                }
            }

            return result;
        }
    }
}