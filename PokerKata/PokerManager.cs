using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerKata
{
    public class PokerManager
    {
        string[] ranks = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A"};
        string[] suits = new string[4] { "S", "C", "D", "H" };

        public string Compare(List<Card> one, List<Card> Two)
        {
            int highestRankOne = 0;
            int highestRankTwo = 0;

            foreach (Card c in one)
            {
                Array.IndexOf(ranks, c.Rank);
                
            }
            return "Hand two wins";
        }
    }
}
