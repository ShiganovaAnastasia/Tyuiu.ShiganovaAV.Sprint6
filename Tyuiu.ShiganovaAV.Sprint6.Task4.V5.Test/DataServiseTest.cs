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

            double[] wait =
            {
                70.14,
                55.21,
                41.05,
                27.96,
                15.48,
                1.0,
                -13.06,
                -28.16,
                -42.96,
                -56.77,
                -69.83
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}