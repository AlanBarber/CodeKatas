using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseString.Tests
{
    [TestClass]
    public class ReverseStringTests
    {
        private ReverseString reverseString;

        [TestInitialize]
        public void TestInitialize()
        {
            reverseString = new ReverseString();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            reverseString = null;
        }
        
        [TestMethod]
        public void ReverseString_HelloWorld()
        {
            string result = reverseString.Reverse("Hello, World!");
            Assert.AreEqual("!dlroW ,olleH", result);
        }

        [TestMethod]
        public void ReverseString_called_twice_returns_original_value()
        {
            const string expected = "Hello, World!";
            string result = reverseString.Reverse(reverseString.Reverse(expected));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseString_returns_empty_string_for_input_of_empty_string()
        {
            string result = reverseString.Reverse(String.Empty);
            Assert.AreEqual(String.Empty, result);
        }
    }
}
