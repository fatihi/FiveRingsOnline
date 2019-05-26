using System.Collections.Generic;
using System.Linq;
using CoreEngine.Cards.CardsImpl;
using CoreEngine.Cards.CartTypes;
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
            var player1Id = System.Guid.NewGuid();
            var player2Id = System.Guid.NewGuid();
            var player1 = new Player
            {
                Id = player1Id,
                Stronghold = new IsawaMoriSeidoCard(),
                Role = new SeekerOfVoidCard(),
                Provinces = new List<ProvinceCard>()
            };
            var player2 = new Player
            {
                Id = player2Id,
                Stronghold = new IsawaMoriSeidoCard()
            };
            var players = new List<Player>
            {
                player1,
                player2
            };

            var game = new CoreEngine.Game.Game(players);

            var gameState = game.GameState;
            gameState.Players.Should().HaveCount(2);
            gameState.Players.First(x => x.Id == player1Id).Stronghold.Should().BeOfType<IsawaMoriSeidoCard>();
        }
    }
}
