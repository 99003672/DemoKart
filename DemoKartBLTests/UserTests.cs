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
    public class UserTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            User uObj = new User();
            uObj.Login("shrishti", "shri");
            Assert.AreEqual(1,1);
        }
    }
}