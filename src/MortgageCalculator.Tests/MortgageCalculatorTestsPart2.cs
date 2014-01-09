using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MortgageCalculator.Tests
{
    [TestClass]
    public class MortgageCalculatorTestsPart2
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
        public void MortgageCalculator_CalculateMonthlyPayment_1()
        {
            var result = mortgageCalculator.CalculateMonthlyPayment(1, 0, 12, 0);
            Assert.AreEqual(1, result);
        }
    }
}
