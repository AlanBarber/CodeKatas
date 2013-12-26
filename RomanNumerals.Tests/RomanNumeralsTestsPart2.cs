using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class RomanNumeralsTestsPart2
    {
        private RomanNumerals romanNumerals;

        [TestInitialize]
        public void TestInitialize()
        {
            romanNumerals = new RomanNumerals();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            romanNumerals = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
