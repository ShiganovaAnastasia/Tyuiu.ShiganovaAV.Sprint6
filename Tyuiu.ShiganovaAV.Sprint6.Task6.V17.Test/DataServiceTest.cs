using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShiganovaAV.Sprint6.Task6.V17.Lib;

namespace Tyuiu.ShiganovaAV.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "ShortLines_Sprint6_V17.txt");
            string testData = "word1 word2\n" +           
                              "onlyOneWord\n" +           
                              "word1 word2 word3 word4\n" + 
                              "word1 word2 word3";         

            File.WriteAllText(path, testData);

            string result = ds.CollectTextFromFile(path);
            string expected = "word3 word3";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Assert.AreEqual(expected, result);
        }
    }
}