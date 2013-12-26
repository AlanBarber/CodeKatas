using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerHandRanking.Tests
{
    [TestClass]
    public class PokerHandRankingTests
    {
        private PokerHandRanking pokerHandRanking;

        [TestInitialize]
        public void TestInitialize()
        {
            pokerHandRanking = new PokerHandRanking();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            pokerHandRanking = null;
        }
        
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
