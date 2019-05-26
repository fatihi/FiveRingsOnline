using System.Collections.Generic;
using CoreEngine.Cards.CardsImpl;
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
            var player1 = new Player
            {
                Stronghold = new IsawaMoriSeidoCard()
            };
            var player2 = new Player();
            var players = new List<Player>
            {
                player1,
                player2
            };

            var game = new CoreEngine.Game.Game(players);

            var gameState = game.GameState;
            gameState.Players.Should().HaveCount(2);
        }
    }
}
