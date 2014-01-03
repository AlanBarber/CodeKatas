using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Tests
{
    [TestClass]
    public class PigLatinTestsPart2
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
        public void PigLatin_returns_hello_for_input_ellohay()
        {
            var result = pigLatin.PigLatinToEnglish("ellohay");
            Assert.AreEqual("hello", result);
        }

        [TestMethod]
        public void PigLatin_returns_i_for_input_iway()
        {
            var result = pigLatin.PigLatinToEnglish("iway");
            Assert.AreEqual("i", result);
        }
    }
}
