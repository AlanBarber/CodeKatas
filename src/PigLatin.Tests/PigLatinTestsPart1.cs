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
        public void PigLatin_returns_ellohay_for_input_hello()
        {
            var result = pigLatin.EnglishToPigLatin("hello");
            Assert.AreEqual("ellohay", result);
        }

        [TestMethod]
        public void PigLatin_returns_iway_for_input_i()
        {
            var result = pigLatin.EnglishToPigLatin("i");
            Assert.AreEqual("iway", result);
        }
    }
}
