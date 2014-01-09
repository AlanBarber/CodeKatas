using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeReturn.Tests
{
    [TestClass]
    public class ChangeReturnTests
    {
        private ChangeReturn changeReturn;

        [TestInitialize]
        public void TestInitialize()
        {
            changeReturn = new ChangeReturn();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            changeReturn = null;
        }  

        [TestMethod]
        public void ChangeReturn_returns_empty_array_when_no_change_should_be_returned()
        {
            var result = changeReturn.GetChange(0, 0);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void ChangeReturn_returns_three_dollars_and_a_nickel()
        {
            var expected = new List<Change>
            {
                new Change() {Denomination = Denomination.OneDollar, Number = 3},
                new Change() {Denomination = Denomination.Nickel, Number = 1}
            };

            var result = changeReturn.GetChange((decimal) 1.95, (decimal) 5.00);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void ChangeReturn_returns_one_of_each_denomination()
        {
            var expected = new List<Change>
            {
                new Change() {Denomination = Denomination.HundredDollar, Number = 1},
                new Change() {Denomination = Denomination.FiftyDollar, Number = 1},
                new Change() {Denomination = Denomination.TwentyDollar, Number = 1},
                new Change() {Denomination = Denomination.TenDollar, Number = 1},
                new Change() {Denomination = Denomination.FiveDollar, Number = 1},
                new Change() {Denomination = Denomination.OneDollar, Number = 1},
                new Change() {Denomination = Denomination.HalfDollar, Number = 1},
                new Change() {Denomination = Denomination.Quarter, Number = 1},
                new Change() {Denomination = Denomination.Dime, Number = 1},
                new Change() {Denomination = Denomination.Nickel, Number = 1},
                new Change() {Denomination = Denomination.Cent, Number = 1}
            };

            var result = changeReturn.GetChange((decimal)13.09, (decimal)200.00);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void ChangeReturn_returns_one_dime_and_one_nickel()
        {
            var expected = new List<Change>
            {
                new Change() {Denomination = Denomination.Dime, Number = 1},
                new Change() {Denomination = Denomination.Nickel, Number = 1}
            };

            var result = changeReturn.GetChange((decimal)0.85, (decimal)1.00);

            CollectionAssert.AreEquivalent(expected, result);            
        }
    }
}
