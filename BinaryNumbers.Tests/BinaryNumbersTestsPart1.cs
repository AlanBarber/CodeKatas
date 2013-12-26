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
        public void TestMethod1()
        {
        }
    }
}
