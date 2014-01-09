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
        public void PiCalculator_GetPi_returns_314_for_input_2()
        {
            var result = piCalculator.GetPi(2);
            Assert.AreEqual("3.14", result);
        }
    }
}
