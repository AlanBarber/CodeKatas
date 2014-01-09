using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class RomanNumeralsTestsPart1
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
        public void RomanNumerals_returns_empty_string_for_input_0()
        {
            var result = romanNumerals.ArabicToRomanNumeral(0);
            Assert.AreEqual(String.Empty, result);
        }

        [TestMethod]
        public void RomanNumerals_returns_I_for_input_1()
        {
            var result = romanNumerals.ArabicToRomanNumeral(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_IV_for_input_4()
        {
            var result = romanNumerals.ArabicToRomanNumeral(4);
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_V_for_input_5()
        {
            var result = romanNumerals.ArabicToRomanNumeral(5);
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_VI_for_input_6()
        {
            var result = romanNumerals.ArabicToRomanNumeral(6);
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_I_for_input_9()
        {
            var result = romanNumerals.ArabicToRomanNumeral(9);
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_I_for_input_10()
        {
            var result = romanNumerals.ArabicToRomanNumeral(10);
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_I_for_input_11()
        {
            var result = romanNumerals.ArabicToRomanNumeral(11);
            Assert.AreEqual("XI", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_L_for_input_50()
        {
            var result = romanNumerals.ArabicToRomanNumeral(50);
            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_C_for_input_100()
        {
            var result = romanNumerals.ArabicToRomanNumeral(100);
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_D_for_input_500()
        {
            var result = romanNumerals.ArabicToRomanNumeral(500);
            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_M_for_input_1000()
        {
            var result = romanNumerals.ArabicToRomanNumeral(1000);
            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_MCMXCIX_for_input_1999()
        {
            var result = romanNumerals.ArabicToRomanNumeral(1999);
            Assert.AreEqual("MCMXCIX", result);
        }

        [TestMethod]
        public void RomanNumerals_returns_MMMMCMXCIX_for_input_4999()
        {
            var result = romanNumerals.ArabicToRomanNumeral(4999);
            Assert.AreEqual("MMMMCMXCIX", result);
        }
    }
}
