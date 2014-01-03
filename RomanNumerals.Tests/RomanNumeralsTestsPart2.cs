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
        public void RomanNumerals_returns_1_for_input_I()
        {
            var result = romanNumerals.RomanNumeralToArabic("I");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_4_for_input_IV()
        {
            var result = romanNumerals.RomanNumeralToArabic("IV");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_5_for_input_V()
        {
            var result = romanNumerals.RomanNumeralToArabic("V");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_6_for_input_VI()
        {
            var result = romanNumerals.RomanNumeralToArabic("VI");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_9_for_input_IX()
        {
            var result = romanNumerals.RomanNumeralToArabic("IX");
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_10_for_input_X()
        {
            var result = romanNumerals.RomanNumeralToArabic("X");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_11_for_input_XI()
        {
            var result = romanNumerals.RomanNumeralToArabic("XI");
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_50_for_input_L()
        {
            var result = romanNumerals.RomanNumeralToArabic("L");
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_100_for_input_C()
        {
            var result = romanNumerals.RomanNumeralToArabic("C");
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_500_for_input_D()
        {
            var result = romanNumerals.RomanNumeralToArabic("D");
            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_1000_for_input_M()
        {
            var result = romanNumerals.RomanNumeralToArabic("M");
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_1999_for_input_MCMXCIX()
        {
            var result = romanNumerals.RomanNumeralToArabic("MCMXCIX");
            Assert.AreEqual(1999, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_4999_for_input_MMMMCMXCIX()
        {
            var result = romanNumerals.RomanNumeralToArabic("MMMMCMXCIX");
            Assert.AreEqual(4999, result);
        }
    }
}
