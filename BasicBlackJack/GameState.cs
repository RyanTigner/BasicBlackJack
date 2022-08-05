using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBlackJack
{
    public sealed class GameState
    {
        private static readonly GameState instance = new GameState();

        public enum GameStates { WIN, LOSE, BUST, PUSH, CONTINUE, ERROR }

        public GameStates CurrentGameState { get; set; }

        private GameState()
        {
            CurrentGameState = GameStates.CONTINUE;
        }

        public static GameState Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
