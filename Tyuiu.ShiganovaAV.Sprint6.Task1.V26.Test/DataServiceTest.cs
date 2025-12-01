using Tyuiu.ShiganovaAV.Sprint6.Task1.V26.Lib;
namespace Tyuiu.ShiganovaAV.Sprint6.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);

            Assert.AreEqual(0, res[5], 0.001);  
            Assert.AreNotEqual(0, res[0], 0.001);
            Assert.AreNotEqual(0, res[10], 0.001);
        }
    }
}
