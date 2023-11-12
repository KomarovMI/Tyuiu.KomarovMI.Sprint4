using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint4.Task7.V25.Lib;

namespace Tyuiu.KomarovMI.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "348561792486";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
