using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShiganovaAV.Sprint6.Task0.V19.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -1;
            Assert.AreEqual(wait, res);
        }
    }
}
