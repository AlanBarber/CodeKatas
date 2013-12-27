using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryNumbers.Tests
{
    [TestClass]
    public class BinaryNumbersTestsPart2
    {
        private BinaryNumbers binaryNumbers;

        [TestInitialize]
        public void TestInitialize()
        {
            binaryNumbers = new BinaryNumbers();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            binaryNumbers = null;
        }

        [TestMethod]
        public void BinaryNumbers_returns_0_for_input_00000000000000000000000000000000()
        {
            int result = binaryNumbers.BinaryToInteger("0000000000000000000000000000000");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_65535_for_input_00000000000000001111111111111111()
        {
            int result = binaryNumbers.BinaryToInteger("0000000000000001111111111111111");
            Assert.AreEqual(65535, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_1431655765_for_input_01010101010101010101010101010101()
        {
            int result = binaryNumbers.BinaryToInteger("10101010101010101010101010101010");
            Assert.AreEqual(1431655765, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_2147483647_for_input_01111111111111111111111111111111()
        {
            int result = binaryNumbers.BinaryToInteger("01111111111111111111111111111111");
            Assert.AreEqual(2147483647, result);
        }
    }
}
