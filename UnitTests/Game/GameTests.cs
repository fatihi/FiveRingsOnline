using System.Collections.Generic;
using CoreEngine.Game;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Game
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameState_Should_ReturnCurrentGameState()
        {
            var players = new List<Player>
            {
                new Player(),
                new Player()
            };

            var game = new CoreEngine.Game.Game(players);

            var gameState = game.GameState;
            gameState.Players.Should().HaveCount(2);
        }
    }
}
