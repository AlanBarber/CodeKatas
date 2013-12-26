using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Tests
{
    [TestClass]
    public class PigLatinTestsPart1
    {
        private PigLatin pigLatin;

        [TestInitialize]
        public void TestInitialize()
        {
            pigLatin = new PigLatin();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            pigLatin = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
