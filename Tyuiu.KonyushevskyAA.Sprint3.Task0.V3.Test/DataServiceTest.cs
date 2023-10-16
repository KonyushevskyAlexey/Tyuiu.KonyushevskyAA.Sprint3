using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint3.Task0.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint3.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
