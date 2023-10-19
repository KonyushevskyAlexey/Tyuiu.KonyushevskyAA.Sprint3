using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint3.Task2.V28.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 1.8;
            int startValue = 1;
            int stopValue = 4;
            double wait = 0.023;

            Assert.AreEqual(wait, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}
