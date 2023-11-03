using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint4.Task2.V5.Lib;

namespace Tyuiu.KarpenkoNA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 9437184;

            Assert.AreEqual(wait, res);
        }
    }
}
