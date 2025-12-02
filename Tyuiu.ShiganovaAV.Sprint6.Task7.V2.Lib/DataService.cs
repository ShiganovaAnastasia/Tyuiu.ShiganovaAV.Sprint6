using System.IO;
using System.Collections.Generic;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShiganovaAV.Sprint6.Task7.V2.Lib
{
    public class DataService : ISprint6Task7V2
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int secondRowIndex = 1; 

            if (secondRowIndex < rows)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (IsEven(matrix[secondRowIndex, j]))
                    {
                        matrix[secondRowIndex, j] = 555;
                    }
                }
            }

            return matrix;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}