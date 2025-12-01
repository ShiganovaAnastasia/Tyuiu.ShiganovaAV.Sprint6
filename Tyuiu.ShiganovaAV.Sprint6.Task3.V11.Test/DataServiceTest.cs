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
            int[,] matrix = ds.GetMatrix();
            int[,] result = ds.Calculate(matrix);

            int[,] expected = {
                { -13, -20, 15, -16, 34 },
                {  -8,  14, -10, 33,  0 },
                {  -3,   1, -1,   5,  1 },
                {   1,   7, -11, -11, 23 },
                {  27, -15, 14,   2, 27 }
            };

            Assert.AreEqual(expected.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expected.GetLength(1), result.GetLength(1));

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}