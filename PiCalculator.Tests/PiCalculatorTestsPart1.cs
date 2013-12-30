using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PiCalculator.Tests
{
    [TestClass]
    public class PiCalculatorTestsPart1
    {
        private PiCalculator piCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            piCalculator = new PiCalculator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            piCalculator = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
