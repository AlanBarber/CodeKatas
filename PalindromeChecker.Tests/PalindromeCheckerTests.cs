using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeChecker.Tests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        private PalindromeChecker palindromeChecker;

        [TestInitialize]
        public void TestInitialize()
        {
            palindromeChecker = new PalindromeChecker();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            palindromeChecker = null;
        }  

        [TestMethod]
        public void PalindromeChecker_returns_true_for_empty_string()
        {
            var result = palindromeChecker.IsPalindrome(String.Empty);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PalindromeChecker_returns_true_for_null()
        {
            var result = palindromeChecker.IsPalindrome(null);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PalindromeChecker_returns_true_for_input_ABBA()
        {
            var result = palindromeChecker.IsPalindrome("ABBA");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PalindromeChecker_returns_true_for_input_tattarrattat()
        {
            var result = palindromeChecker.IsPalindrome("tattarrattat");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void PalindromeChecker_returns_false_for_input_ABCD()
        {
            var result = palindromeChecker.IsPalindrome("ABCD");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void PalindromeChecker_returns_false_for_input_palindrome()
        {
            var result = palindromeChecker.IsPalindrome("palindrome");
            Assert.AreEqual(false, result);
        } 
    }
}
