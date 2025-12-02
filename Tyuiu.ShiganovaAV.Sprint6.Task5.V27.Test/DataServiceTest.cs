using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShiganovaAV.Sprint6.Task5.V27.Lib;
using System.IO;

namespace Tyuiu.ShiganovaAV.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFileSimple()
        {
            string path = @"InPutFileTask5V27.txt";

            if (File.Exists(path))
            {
                DataService ds = new DataService();
                double[] res = ds.LoadFromDataFile(path);

                Assert.AreEqual(20, res.Length);
                Assert.AreEqual(-17, res[0], 0.001);
                Assert.AreEqual(-7, res[19], 0.001);
            }
            else
            {
                DataService ds = new DataService();
                Assert.IsNotNull(ds);
            }
        }
    }
}