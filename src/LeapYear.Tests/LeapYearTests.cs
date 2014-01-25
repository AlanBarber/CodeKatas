using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear.Tests
{
    [TestClass]
    public class LeapYearTests
    {
        private LeapYear leapYear;

        [TestInitialize]
        public void TestInitialize()
        {
            leapYear = new LeapYear();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            leapYear = null;
        }

        [TestMethod]
        public void LeapYear_returns_true_for_1904()
        {
            bool result = leapYear.IsLeapYear(1904);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_1952()
        {
            bool result = leapYear.IsLeapYear(1952);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_2000()
        {
            bool result = leapYear.IsLeapYear(2000);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_2012()
        {
            bool result = leapYear.IsLeapYear(2012);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_2048()
        {
            bool result = leapYear.IsLeapYear(2048);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_2096()
        {
            bool result = leapYear.IsLeapYear(2096);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_1700()
        {
            bool result = leapYear.IsLeapYear(1700);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_1900()
        {
            bool result = leapYear.IsLeapYear(1900);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_2100()
        {
            bool result = leapYear.IsLeapYear(2100);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_2001()
        {
            bool result = leapYear.IsLeapYear(2001);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_2014()
        {
            bool result = leapYear.IsLeapYear(2014);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_2050()
        {
            bool result = leapYear.IsLeapYear(2050);
            Assert.IsFalse(result);
        }

        /*
        //UNCOMMENT THIS SECTION FOR EXTRA CREDIT
        [TestMethod]
        public void LeapYear_returns_false_for_4AD()
        {
            bool result = leapYear.IsLeapYear(4);
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void LeapYear_returns_false_for_0AD()
        {
            bool result = leapYear.IsLeapYear(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_false_for_50BC()
        {
            bool result = leapYear.IsLeapYear(-50);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_8AD()
        {
            bool result = leapYear.IsLeapYear(8);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_30BC()
        {
            bool result = leapYear.IsLeapYear(-30);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeapYear_returns_true_for_45BC()
        {
            bool result = leapYear.IsLeapYear(-45);
            Assert.IsTrue(result);
        }        
         */
    }
}