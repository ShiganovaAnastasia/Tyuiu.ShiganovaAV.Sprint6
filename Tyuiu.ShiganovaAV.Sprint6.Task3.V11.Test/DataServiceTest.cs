using Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Lib;
namespace Tyuiu.ShiganovaAV.Sprint6.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetMatrix();

            Assert.AreEqual(5, matrix.GetLength(0));
            Assert.AreEqual(5, matrix.GetLength(1));

            Assert.AreEqual(27, matrix[0, 0]);
            Assert.AreEqual(-15, matrix[0, 1]);
            Assert.AreEqual(-13, matrix[3, 0]);
            Assert.AreEqual(34, matrix[3, 4]);
        }
    }
}
