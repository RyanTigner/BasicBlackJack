using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Player_Dealer : Player
    {
        public void Play(DeckOfCards_Standard_52<Card_Standard_52> Deck52)
        {
            while (!this.MustStay())
            {
                this.AddCardToHand(Deck52.DrawTopCard(new Position(this.Hand[this.Hand.Count - 1].Position.X() + this.Hand[this.Hand.Count - 1].Deminsons.Width() + 1,
                                                      this.Hand[0].Position.Y(),
                                                      this.Hand[0].Position.Z())));
            }
        }

        public bool MustStay()
        {
            if (this.m_iHandValue >= 17 && this.m_iHandValue <= 21)
                return true;

            return false;
        }
    }
}
