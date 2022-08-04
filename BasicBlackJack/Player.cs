using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Player
    {
        public List<Card_Standard_52> Hand = new List<Card_Standard_52>();
        public int m_iHandValue { get; set; }

        public bool m_bStayed { get; set; }

        public Position startPosition { get; set; }

        public Player()
        {
            this.m_iHandValue = 0;
        }

        public Player(Position startPosition)
        {
            this.startPosition = startPosition;
            this.m_iHandValue = 0;
        }

        public void AddCardToHand(Card_Standard_52 card)
        {
            this.Hand.Add(card);
            SetHandValue();
        }

        public void AddCardToHand(Card_Standard_52 card, bool cardFaceUp)
        {
            card.m_bFaceUp = cardFaceUp;
            this.Hand.Add(card);
            
            SetHandValue();
        }

        public void SetHandValue()
        {
            this.m_iHandValue = 0;

            foreach (Card_Standard_52 card in Hand)
            {
                //accounting for ACE
                if(card.m_iValue == 1)
                    this.m_iHandValue += 11;
                else
                    this.m_iHandValue += card.m_iValue;     
            }

            //accounting for ACE
            int x = 0;
            while (this.m_iHandValue > 21 && this.Hand.Count >= x + 1)
            {
                if (this.Hand[x].m_iValue == 1)
                    this.m_iHandValue -= 10;

                x++;
            }
        }

        public bool WentBust()
        {
            if(this.m_iHandValue > 21)
            {
                return true;
            }

            return false;
        }

        public bool Has21()
        {
            if(this.m_iHandValue == 21)
            {
                return true;
            }

            return false;
        }
    }
}
