using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerKata
{
    public class Hand
    {
        List<Card> Cards = new List<Card>();

        public Hand(List<Card> cards)
        {
            this.Cards = cards;
        }
    }
}
