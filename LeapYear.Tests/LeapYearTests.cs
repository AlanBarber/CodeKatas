using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear.Tests
{
    [TestClass]
    public class LeapYearTests
    {
        private LeapYear leapYear;

        [TestInitialize]
        public void TestInitialize()
        {
            leapYear = new LeapYear();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            leapYear = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
