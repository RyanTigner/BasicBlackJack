using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicBlackJack
{
    public sealed class Gameplay
    {
        Graphics graphics = Graphics.Instance;
        private Player player = new Player();
        private Player_Dealer dealer = new Player_Dealer();
        private DeckOfCards_Standard_52<Card_Standard_52> Deck52;

 
        private static readonly Gameplay instance = new Gameplay();

        private Gameplay()
        {
            NewGame();
            Update();
        }
        public static Gameplay Instance
        {
            get
            {
                return instance;
            }
        }

        private void Update()
        {
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1: //Hit
                        if (!player.WentBust() && !player.Has21())
                        {
                            player.AddCardToHand(Deck52.DrawTopCard(new Position(player.Hand[player.Hand.Count - 1].Position.X() + player.Hand[player.Hand.Count - 1].Deminsons.Width() + 1, 
                                                                                 player.Hand[0].Position.Y(), 
                                                                                 player.Hand[0].Position.Z())));
                            Console.Clear();
                            graphics.Draw(player, dealer);
                        }
                        break;
                    case ConsoleKey.D2: //Stay
                        if (!player.WentBust() && !player.Has21())
                        {
                            player.m_bStayed = true;
                            dealer.Hand[1].m_bFaceUp = true;
                            dealer.Play(Deck52);
                            graphics.Draw(player, dealer);                        
                        }
                        break;
                    case ConsoleKey.Escape: //Exit Game
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Y: //Play Another Game
                        if (player.WentBust() || player.Has21())
                        {
                            NewGame();
                        }
                        break;
                    case ConsoleKey.N: //Don't Play another game and exit
                        if (player.WentBust() || player.Has21())
                            Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        private void NewGame()
        {    
            Deck52 = new DeckOfCards_Standard_52<Card_Standard_52>();
            Deck52.Shuffle();
            DealHand();

            //initial draw of game
            Console.Clear();
            graphics.Draw(player, dealer);
        }

        private void DealHand()
        {
            player.Hand.Clear();
            player.AddCardToHand(Deck52.DrawTopCard());
            player.Hand[0].Position.SetPosition(0, 6, 0);
            player.AddCardToHand(Deck52.DrawTopCard());
            player.Hand[1].Position.SetPosition(6, 6, 0);

            dealer.Hand.Clear();
            dealer.AddCardToHand(Deck52.DrawTopCard());
            dealer.Hand[0].Position.SetPosition(0, 1, 0);
            dealer.AddCardToHand(Deck52.DrawTopCard(), false);
            dealer.Hand[1].Position.SetPosition(6, 1, 0);
        }
    }
}
