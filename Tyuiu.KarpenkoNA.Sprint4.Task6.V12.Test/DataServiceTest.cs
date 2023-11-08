using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpenkoNA.Sprint4.Task6.V12.Lib;

namespace Tyuiu.KarpenkoNA.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] mas = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            string[] res = ds.Calculate(mas);
            string[] wait = { "Украина", "Молдова", "Эстония" };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
