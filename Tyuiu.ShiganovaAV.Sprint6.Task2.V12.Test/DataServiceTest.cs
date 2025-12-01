using Tyuiu.ShiganovaAV.Sprint6.Task2.V12.Lib;
namespace Tyuiu.ShiganovaAV.Sprint6.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 2;
            int stopValue = 2;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(1, res.Length);
            Assert.AreEqual(3.31, Math.Round(res[0], 2));
        }
    }
}
