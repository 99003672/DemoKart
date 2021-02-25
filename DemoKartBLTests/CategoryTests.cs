using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL.Tests
{
    [TestClass()]
    public class CategoryTests
    {
        [TestMethod()]
        public void CalculatePriceTest()
        {
            double expected = 236;
            var CategoryObj = new Category();
            double actual = CategoryObj.CalculatePrice(1, 100, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}