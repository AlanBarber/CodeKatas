using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.Tests
{
    [TestClass]
    public class CaesarCipherTests
    {
        private CaesarCipher caesarCipher;

        [TestInitialize]
        public void TestInitialize()
        {
            caesarCipher = new CaesarCipher();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            caesarCipher = null;
        }  

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
