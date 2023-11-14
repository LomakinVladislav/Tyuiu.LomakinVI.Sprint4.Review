using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint4.TaskReview.V29.Lib;

namespace Tyuiu.LomakinVI.Sprint4.TaskReview.V29.Test
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
            string value = "983157642891";
            DataService ds = new DataService();

            Assert.AreEqual(28, ds.Calculate(n, m, value));
        }
    }
}
