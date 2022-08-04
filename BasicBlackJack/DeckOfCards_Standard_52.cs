using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class DeckOfCards_Standard_52<T> : DeckOfCards<Card_Standard_52>
    {
        public DeckOfCards_Standard_52()
        {
            this.m_iMaxDeckSize = 52;
            BuildDeck();
        }

        public override Card_Standard_52 DrawTopCard()
        {
            Card_Standard_52 topCard = this[0];
            this.RemoveAt(0);

            return topCard;
        }

        public override Card_Standard_52 DrawTopCard(Position position)
        {
            Card_Standard_52 topCard = this[0];
            this.RemoveAt(0);
            topCard.Position = position;

            return topCard;
        }

        public DeckOfCards_Standard_52<T> getDeck
        {
            get
            {
                return this;
            }
        }

        public override void BuildDeck()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    if (y == 10)
                    {
                        for (int z = 0; z < 4; z++)
                        {
                            this.Add(new Card_Standard_52(y, (Card_Standard_52.SUIT)x, (Card_Standard_52.RANK)(y+z), new Position(0,0,0), new Shape_2D_Rectangle(4, 5), new Card.Image("i", "i")));
                        }
                    }
                    else
                    {
                        this.Add(new Card_Standard_52(y, (Card_Standard_52.SUIT)x, (Card_Standard_52.RANK)y, new Position(0, 0, 0), new Shape_2D_Rectangle(4, 5), new Card.Image("i", "i")));
                    }               
                }
            }
        }
    }
}
