using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MortgageCalculator.Tests
{
    [TestClass]
    public class MortgageCalculatorTestsPart1
    {
        private MortgageCalculator mortgageCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            mortgageCalculator = new MortgageCalculator();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            mortgageCalculator = null;
        }
        
        [TestMethod]
        public void MortgageCalculator_CalculatePurchasePrice_1()
        {
            var result = mortgageCalculator.CalculatePurchasePrice(1, 1, 1, 1);
            Assert.AreEqual(12.95, result);
        }
    }
}
