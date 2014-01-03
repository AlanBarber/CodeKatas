using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PiCalculator.Tests
{
    [TestClass]
    public class PiCalculatorTestsPart2
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
        public void PiCalculator_GetPiDigit_returns_1_for_input_1()
        {
            var result = piCalculator.GetPiDigit(1);
            Assert.AreEqual(1, result);
        }
    }
}
