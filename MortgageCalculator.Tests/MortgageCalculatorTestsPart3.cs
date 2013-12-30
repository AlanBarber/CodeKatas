using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MortgageCalculator.Tests
{
    [TestClass]
    public class MortgageCalculatorTestsPart3
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
        public void TestMethod1()
        {
        }
    }
}
