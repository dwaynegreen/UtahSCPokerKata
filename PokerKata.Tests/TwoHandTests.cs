using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PokerKata.Tests
{
    [TestFixture]
    public class TwoHandTests
    {
        [Test]
        public void TestHandOneWins()
        {
            List<Card> handOne = new List<Card>
            {
                new Card("S", "A"),
                new Card("H", "2"),
                new Card("S", "6"),
                new Card("D", "9"),
                new Card("S", "10")
            };
            List<Card> handTwo = new List<Card>
            {
                new Card("S", "9"),
                new Card("H", "3"),
                new Card("S", "8"),
                new Card("D", "9"),
                new Card("S", "4")
            };

            PokerManager pokerManager = new PokerManager();
            string result = pokerManager.Compare(handOne, handTwo);

            Assert.True(result == "Hand one wins");
        }
   
        [Test]
        public void TestHandTwoWins()
        {
            List<Card> handOne = new List<Card>
            {
                new Card("S", "7"),
                new Card("H", "2"),
                new Card("S", "6"),
                new Card("D", "9"),
                new Card("S", "10")
            };
            List<Card> handTwo = new List<Card>
            {
                new Card("S", "A"),
                new Card("H", "3"),
                new Card("S", "8"),
                new Card("D", "9"),
                new Card("S", "4")
            };

            PokerManager pokerManager = new PokerManager();
            string result = pokerManager.Compare(handOne, handTwo);

            Assert.True(result == "Hand two wins");
        }

        [Test]
        public void TestHandsTie()
        {
            List<Card> handOne = new List<Card>
            {
                new Card("S", "Q"),
                new Card("H", "2"),
                new Card("S", "6"),
                new Card("D", "9"),
                new Card("S", "10")
            };
            List<Card> handTwo = new List<Card>
            {
                new Card("S", "9"),
                new Card("H", "3"),
                new Card("S", "T"),
                new Card("D", "9"),
                new Card("S", "4")
            };

            PokerManager pokerManager = new PokerManager();
            string result = pokerManager.Compare(handOne, handTwo);

            Assert.True(result == "Hand one wins");
        }
    }
}
