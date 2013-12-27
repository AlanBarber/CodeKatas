using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LookAndSay.Tests
{
    [TestClass]
    public class LookAndSayTests
    {
        private LookAndSay lookAndSay;

        [TestInitialize]
        public void TestInitialize()
        {
            lookAndSay = new LookAndSay();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            lookAndSay = null;
        }  

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
