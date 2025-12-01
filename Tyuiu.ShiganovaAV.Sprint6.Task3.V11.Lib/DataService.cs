using tyuiu.cources.programming.interfaces.Sprint1;
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

            int[][] rowsArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                rowsArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowsArray[i][j] = matrix[i, j];
                }
            }
            var sortedRows = rowsArray.OrderBy(row => row[0]).ToArray();

            int[,] sortedMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[i, j] = sortedRows[i][j];
                }
            }

            return sortedMatrix;
        }
    }
}
