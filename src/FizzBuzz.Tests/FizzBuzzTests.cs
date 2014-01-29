using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;
        
        [TestInitialize]
        public void TestInitialize()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            fizzBuzz = null;
        }
        
        [TestMethod]
        public void FizzBuzz_returns_1_for_input_1()
        {
            string result = fizzBuzz.Check(1);
            Assert.AreEqual("1",result);
        }

        [TestMethod]
        public void FizzBuzz_returns_Fizz_for_input_3()
        {
            string result = fizzBuzz.Check(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzz_returns_Buzz_for_input_5()
        {
            string result = fizzBuzz.Check(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FizzBuzz_returns_Fizz_for_input_6()
        {
            string result = fizzBuzz.Check(6);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FizzBuzz_returns_Buzz_for_input_10()
        {
            string result = fizzBuzz.Check(10);
            Assert.AreEqual("Buzz", result); 
        }

        [TestMethod]
        public void FizzBuzz_returns_FizzBuzz_for_input_15()
        {
            string result = fizzBuzz.Check(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzz_returns_FizzBuzz_for_input_30()
        {
            string result = fizzBuzz.Check(30);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void FizzBuzz_returns_64_for_input_64()
        {
            string result = fizzBuzz.Check(64);
            Assert.AreEqual("64", result);
        }
    }
}
