using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public class Card_Standard_52 : Card
    {
        public enum SUIT { SPADE, HEART, DIAMOND, CLUB }
        public enum RANK { ACE = 1, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING }
        public int m_iValue { get; set; }

        SUIT m_eSuit { get; set; }
        RANK m_eRank { get; set; }

        public char m_sSuit;
        public char m_sRank;


        public Card_Standard_52(int value, SUIT suit, RANK rank, Position position, Shape_2D_Rectangle deminsions, Image image) : base(position, deminsions, image)
        {
            this.m_iValue = value;
            this.m_eSuit = suit;
            this.m_eRank = rank;
            this.m_bFaceUp = true;
            this.m_sSuit = GetSuitChar();
            this.m_sRank = GetRankChar();
        }
        public Card_Standard_52(int value, SUIT suit, RANK rank)
        {
            this.m_iValue = value;
            this.m_eSuit = suit;
            this.m_eRank = rank;
            this.m_bFaceUp = true;
            this.m_sSuit = GetSuitChar();
            this.m_sRank = GetRankChar();
        }


        //public void Draw()
        //{
        //    //top of card
        //    WriteAt("\u250C", card.Position.X(), card.Position.Y());
        //    for (int x = 2; x < card.Deminsons.Width(); ++x)
        //    {
        //        WriteAt("\u2500", card.Position.X() + x - 1, card.Position.Y());
        //    }
        //    WriteAt("\u2510", card.Position.X() - 1 + card.Deminsons.Width(), card.Position.Y());


        //    //middle of card
        //    for (int y = 1; y < card.Deminsons.Length(); y++)
        //    {
        //        WriteAt("\u2502", card.Position.X(), card.Position.Y() + y);
        //        WriteAt("\u2502", card.Position.X() + card.Deminsons.Length(), card.Position.Y() + y);
        //    }
        //    if (card.m_bFaceUp)
        //    {
        //        WriteAt(Convert.ToString(card.m_sRank), card.Position.X() + 1, card.Position.Y() + 1);
        //        WriteAt(Convert.ToString(card.m_sSuit), card.Position.X() + card.Deminsons.Width() - 2, card.Position.Y() + card.Deminsons.Length() - 2);
        //    }

        //    //bottom of card
        //    WriteAt("\u2514", card.Position.X(), card.Position.Y() + card.Deminsons.Length() - 1);
        //    for (int x = 2; x < card.Deminsons.Width(); ++x)
        //    {
        //        WriteAt("\u2500", card.Position.X() + x - 1, card.Position.Y() + card.Deminsons.Length() - 1);
        //    }
        //    WriteAt("\u2518", card.Position.X() - 1 + card.Deminsons.Width(), card.Position.Y() + card.Deminsons.Length() - 1);
        //}


        private char GetSuitChar()
        {
            switch(this.m_eSuit)
            {
                case SUIT.SPADE:
                    return '\u2660';                  
                case SUIT.HEART:
                    return '\u2665';
                case SUIT.DIAMOND:
                    return '\u2666';
                case SUIT.CLUB:
                    return '\u2663';
                default:
                    break;
            }

            return ' ';
        }

        private char GetRankChar()
        {
            switch (this.m_eRank)
            {
                case RANK.ACE:
                    return 'A';
                case RANK.TWO:
                    return '2';
                case RANK.THREE:
                    return '3';
                case RANK.FOUR:
                    return '4';
                case RANK.FIVE:
                    return '5';
                case RANK.SIX:
                    return '6';
                case RANK.SEVEN:
                    return '7';
                case RANK.EIGHT:
                    return '8';
                case RANK.NINE:
                    return '9';
                case RANK.TEN:
                    return 'X';
                case RANK.JACK:
                    return 'J';
                case RANK.QUEEN:
                    return 'Q';
                case RANK.KING:
                    return 'K';
                default:
                    break;
            }

            return ' ';
        }

        public static bool operator >(Card_Standard_52 card1, Card_Standard_52 card2)
        {
            if (card1.m_iValue > card2.m_iValue)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Card_Standard_52 card1, Card_Standard_52 card2)
        {
            if (card1.m_iValue < card2.m_iValue)
            {
                return true;
            }

            return false;
        }

        public static bool operator >=(Card_Standard_52 card1, Card_Standard_52 card2)
        {
            if (card1.m_iValue >= card2.m_iValue)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Card_Standard_52 card1, Card_Standard_52 card2)
        {
            if (card1.m_iValue <= card2.m_iValue)
            {
                return true;
            }

            return false;
        }
    }
}
