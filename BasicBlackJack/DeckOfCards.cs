using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public abstract class DeckOfCards<T> : List<T>
    {
        protected int m_iMaxDeckSize { get; set; }

        public abstract void BuildDeck();

        public abstract T DrawTopCard();

        public abstract T DrawTopCard(Position position);

        public void Shuffle()
        {
            Random rng = new Random();

            int n = this.Count;

            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = this[k];
                this[k] = this[n];
                this[n] = value;

            }
        }

        //public static List<T> operator +(DeckOfCards<T> Deck, T Card)
        //{
        //    Deck.Add(Card);
            
        //    return Deck;
        //}

        //public static List<T> operator -(DeckOfCards<T> Deck, T Card)
        //{
        //    Deck.Remove(Card);

        //    return Deck;
        //}

    }
}
