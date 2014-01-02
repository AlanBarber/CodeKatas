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
            var result = binaryNumbers.BinaryToInteger("0000000000000000000000000000000");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_1_for_input_00000000000000000000000000000001()
        {
            var result = binaryNumbers.BinaryToInteger("0000000000000000000000000000001");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_1024_for_input_0000000000000000000010000000000()
        {
            var result = binaryNumbers.BinaryToInteger("0000000000000000000010000000000");
            Assert.AreEqual(1024, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_65535_for_input_00000000000000001111111111111111()
        {
            var result = binaryNumbers.BinaryToInteger("0000000000000001111111111111111");
            Assert.AreEqual(65535, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_10485760_for_input_000000000010000000000000000000()
        {
            var result = binaryNumbers.BinaryToInteger("0000000000100000000000000000000");
            Assert.AreEqual(1048576, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_1431655765_for_input_01010101010101010101010101010101()
        {
            var result = binaryNumbers.BinaryToInteger("10101010101010101010101010101010");
            Assert.AreEqual(1431655765, result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_2147483647_for_input_01111111111111111111111111111111()
        {
            var result = binaryNumbers.BinaryToInteger("01111111111111111111111111111111");
            Assert.AreEqual(2147483647, result);
        }
    }
}
