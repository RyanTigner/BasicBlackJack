using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public sealed class Graphics
    {
        private static readonly Graphics instance = new Graphics();

        private Graphics()
        {

        }
        public static Graphics Instance
        {
            get
            {
                return instance;
            }
        }

        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, float x, float y)
        {
            try
            {
                Console.SetCursorPosition(origCol + Convert.ToInt32(x), origRow + Convert.ToInt32(y));
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void Draw(Player player, Player_Dealer dealer, bool continueGame)
        {
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            DrawDealerPlayArea(dealer.Hand);
            DrawPlayerPlayArea(player.Hand);
            DrawPlayerOptions(continueGame);
        }

        private void DrawDealerPlayArea(List<Card_Standard_52> dealerHand)
        {
            Console.WriteLine("DEALER HAND");

            foreach (Card_Standard_52 card in dealerHand)
            {
                DrawCard(card);
            }

            Console.WriteLine();
        }

        private void DrawPlayerPlayArea(List<Card_Standard_52> playerHand)
        {
            Console.WriteLine("PLAYER HAND");

            foreach (Card_Standard_52 card in playerHand)
            {
                DrawCard(card);
            }

            Console.WriteLine();
        }

        private void DrawCard(Card_Standard_52 card)
        {
            //top of card
            WriteAt("\u250C", card.Position.X(), card.Position.Y());
            for (int x = 2; x < card.Deminsons.Width(); ++x)
            {
                WriteAt("\u2500", card.Position.X() + x - 1, card.Position.Y());
            }
            WriteAt("\u2510", card.Position.X() - 1 + card.Deminsons.Width(), card.Position.Y());


            //middle of card
            for (int y = 1; y < card.Deminsons.Length(); y++)
            {
                WriteAt("\u2502", card.Position.X(), card.Position.Y() + y);           
                WriteAt("\u2502", card.Position.X() + card.Deminsons.Length(), card.Position.Y() + y);
            }
            if (card.m_bFaceUp)
            {
                WriteAt(Convert.ToString(card.m_sRank), card.Position.X() + 1, card.Position.Y() + 1);
                WriteAt(Convert.ToString(card.m_sSuit), card.Position.X() + card.Deminsons.Width() - 2, card.Position.Y() + card.Deminsons.Length() - 2);
            }

            //bottom of card
            WriteAt("\u2514", card.Position.X(), card.Position.Y() + card.Deminsons.Length() - 1);
            for (int x = 2; x < card.Deminsons.Width(); ++x)
            {
                WriteAt("\u2500", card.Position.X() + x - 1, card.Position.Y() + card.Deminsons.Length() - 1);
            }
            WriteAt("\u2518", card.Position.X() - 1 + card.Deminsons.Width(), card.Position.Y() + card.Deminsons.Length() - 1);
        }



        private void DrawPlayerOptions(bool continueGame)
        {
            if (continueGame)
            {
                Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                Console.WriteLine("\u2551 1.Hit   2.Stay         \u2551");
                Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
            }
            else {
                Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
                Console.WriteLine("\u2551 New Game?(y/n)         \u2551");
                Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");

            }
        }
    }
}
