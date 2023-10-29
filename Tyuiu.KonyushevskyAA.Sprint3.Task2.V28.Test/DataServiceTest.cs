using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint3.Task2.V28.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            
            int startValue = 1;
            int stopValue = 4;

            double res =  ds.GetMultiplySeries(startValue, stopValue);

            double wait = 0.023;

            Assert.AreEqual(wait, res);
        }
    }
}
