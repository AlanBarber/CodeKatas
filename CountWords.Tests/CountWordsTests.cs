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
        public void CountWords_returns_0_for_empty_string()
        {
            int result = countWords.Count(String.Empty);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CountWords_returns_2_for_HelloWorld()
        {
            int result = countWords.Count("Hello, World!");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountWords_returns_4_for_comma_seperated_list_with_no_spaces()
        {
            int result = countWords.Count("Billy,Bob,Joe,Jim");
            Assert.AreEqual(4, result);
        }
    }
}
