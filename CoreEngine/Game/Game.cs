using System.Collections.Generic;

namespace CoreEngine.Game
{
    public class Game
    {
        public Game(IEnumerable<Player> players)
        {
            GameState = new GameState {Players = players};
        }

        public GameState GameState { get; set; }
    }
}
