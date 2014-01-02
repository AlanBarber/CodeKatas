using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryNumbers.Tests
{
    [TestClass]
    public class BinaryNumbersTestsPart1
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
        public void BinaryNumbers_returns_00000000000000000000000000000000_for_input_0()
        {
            var result = binaryNumbers.IntegerToBinary(0);
            Assert.AreEqual("0000000000000000000000000000000", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_00000000000000000000000000000001_for_input_1()
        {
            var result = binaryNumbers.IntegerToBinary(0);
            Assert.AreEqual("0000000000000000000000000000001", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_0000000000000000000010000000000_for_input_1024()
        {
            var result = binaryNumbers.IntegerToBinary(0);
            Assert.AreEqual("0000000000000000000010000000000", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_00000000000000001111111111111111_for_input_65535()
        {
            var result = binaryNumbers.IntegerToBinary(65535);
            Assert.AreEqual("0000000000000001111111111111111", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_0000000000100000000000000000000_for_input_1048576()
        {
            var result = binaryNumbers.IntegerToBinary(1048576);
            Assert.AreEqual("0000000000100000000000000000000", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_01010101010101010101010101010101_for_input_1431655765()
        {
            var result = binaryNumbers.IntegerToBinary(1431655765);
            Assert.AreEqual("10101010101010101010101010101010", result);
        }

        [TestMethod]
        public void BinaryNumbers_returns_01111111111111111111111111111111_for_input_2147483647()
        {
            var result = binaryNumbers.IntegerToBinary(2147483647);
            Assert.AreEqual("01111111111111111111111111111111", result);
        }
    }
}
