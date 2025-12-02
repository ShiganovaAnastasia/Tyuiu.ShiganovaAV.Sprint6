using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShiganovaAV.Sprint6.Task4.V5.Lib;
namespace Tyuiu.ShiganovaAV.Sprint6.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = { 69.85, 28.11, 13.95, 6.31, 1, 0.67, -13.31, -27.94, -34.11, -43.28, -69.85 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
