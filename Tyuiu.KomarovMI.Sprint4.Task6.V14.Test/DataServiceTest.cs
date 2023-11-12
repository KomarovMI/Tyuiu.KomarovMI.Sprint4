using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMI.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KomarovMI.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            var res = ds.Calculate(month);
            var wait = new string[] { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };
            CollectionAssert.AreEqual(wait, res);


        }
    }
}
