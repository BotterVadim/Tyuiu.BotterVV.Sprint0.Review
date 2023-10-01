using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint0.Review.V0.Lib;

namespace Tyuiu.BotterVV.Sprint0.Review.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(30, DataService.Calc(2, 2, 2));
        }
    }
}
