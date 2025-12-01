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
            int[,] matrix = new int[0, 0];

            var result = ds.Calculate(matrix);

            Assert.AreEqual(0, result.GetLength(0));
            Assert.AreEqual(0, result.GetLength(1));
        }
    }
}
