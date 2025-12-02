using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShiganovaAV.Sprint6.Task7.V2.Lib;
namespace Tyuiu.ShiganovaAV.Sprint6.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
                DataService ds = new DataService();

                string path = Path.Combine(Path.GetTempPath(), "RealData.csv");

                string testData = "-19;-8;-5;17;13;-6;20;3;8;3\n" +
                                  "-8;-14;20;11;-8;12;-13;-13;-11;-6\n" +
                                  "-8;20;14;-8;-8;10;-13;8;-10;-15\n" +
                                  "17;16;-20;-16;-9;20;-13;-15;-12;3\n" +
                                  "-18;-16;-16;-18;1;8;8;2;-3;1\n" +
                                  "-7;0;-5;4;-19;-11;-18;20;16;-1\n" +
                                  "6;7;1;-8;-19;17;-11;0;15;18\n" +
                                  "6;15;1;-5;-4;-6;12;-11;-19;-19\n" +
                                  "15;-10;16;16;6;0;16;17;-10;-10\n" +
                                  "19;7;5;-9;-4;12;19;-20;8;10";

                File.WriteAllText(path, testData);

                int[,] result = ds.GetMatrix(path);

                Assert.AreEqual(555, result[1, 0]); 
                Assert.AreEqual(555, result[1, 1]); 
                Assert.AreEqual(555, result[1, 2]); 
                Assert.AreEqual(11, result[1, 3]);  
                Assert.AreEqual(555, result[1, 4]);
                Assert.AreEqual(555, result[1, 5]);
                Assert.AreEqual(-13, result[1, 6]);
                Assert.AreEqual(-13, result[1, 7]); 
                Assert.AreEqual(-11, result[1, 8]); 
                Assert.AreEqual(555, result[1, 9]);  

                Assert.AreEqual(-19, result[0, 0]);
                Assert.AreEqual(-8, result[2, 0]);
                Assert.AreEqual(17, result[3, 0]);

                File.Delete(path);
            }
        }
    }
