using System;
using System.Collections.Generic;
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
        public void PokerHandRanking_returns_royal_flush()
        {
            var hand = new List<Card>()
            {
                new Card() { Rank = Rank.Ace, Suit = Suit.Club },
                new Card() { Rank = Rank.King, Suit = Suit.Club },
                new Card() { Rank = Rank.Queen, Suit = Suit.Club },
                new Card() { Rank = Rank.Jack, Suit = Suit.Club },
                new Card() { Rank = Rank.Ten, Suit = Suit.Club }
            };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Royal Flush", result);
        }
    }
}
