using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeReturn.Tests
{
    [TestClass]
    public class ChangeReturnTests
    {
        private ChangeReturn changeReturn;

        [TestInitialize]
        public void TestInitialize()
        {
            changeReturn = new ChangeReturn();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            changeReturn = null;
        }  

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
