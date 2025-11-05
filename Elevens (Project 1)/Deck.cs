using System;
using System.Collections.Generic;
using System.Linq;

namespace Elevens
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        private static readonly string[] Suits =
            { "Hearts", "Diamonds", "Clubs", "Spades" };

        private static readonly string[] Ranks =
            { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        private static readonly int[] Values =
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };

        public Deck()
        {
            foreach (string suit in Suits)
            {
                for (int i = 0; i < Ranks.Length; i++)
                {
                    cards.Add(new Card(Ranks[i], suit, Values[i]));
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(c => random.Next()).ToList();
        }

        public Card Deal()
        {
            if (cards.Count == 0)
                return null;

            Card top = cards[0];
            cards.RemoveAt(0);
            return top;
        }

        public int Size()
        {
            return cards.Count;
        }
    }
}
