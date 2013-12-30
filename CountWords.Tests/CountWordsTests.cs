using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountWords.Tests
{
    [TestClass]
    public class CountWordsTests
    {
        private CountWords countWords;

        [TestInitialize]
        public void TestInitialize()
        {
            countWords = new CountWords();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            countWords = null;
        } 

        [TestMethod]
        public void CountWorlds_returns_0_for_empty_string()
        {
            int result = countWords.Count(String.Empty);
            Assert.AreEqual(0, result);
        }
    }
}
