using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
            {
            DataService ds = new DataService();

            // Создаем НЕОТСОРТИРОВАННУЮ матрицу вручную
            int[,] matrix = new int[5, 5]
            {
                { 27, -15, 14,  2, 27 },
                { -8,  14, -10, 33,  0 },
                {  1,   7, -11, -11, 23 },
                { -13, -20, 15, -16, 34 },
                { -3,   1, -1,   5,  1 }
            };

            // Вызываем Calculate для сортировки
            int[,] result = ds.Calculate(matrix);

            // Ожидаемый результат после сортировки первого столбца
            int[,] expected = {
                { -13, -15, 14,   2, 27 },
                {  -8,  14, -10, 33,  0 },
                {  -3,   7, -11, -11, 23 },
                {   1, -20,  15, -16, 34 },
                {  27,   1,  -1,   5,  1 }
            };
            Assert.AreEqual(expected.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), result.GetLength(1));

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }