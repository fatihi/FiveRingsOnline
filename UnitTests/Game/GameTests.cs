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
            var firstPlayerId = System.Guid.NewGuid();
            var firstPlayerStronghold = new IsawaMoriSeidoCard();
            var players = new List<Player>
            {
                new Player
                {
                    Id = firstPlayerId,
                    Stronghold = firstPlayerStronghold,
                    Role = new SeekerOfVoidCard(),
                    Provinces = new List<Province>
                    {
                        new Province
                        {
                            ProvinceCard = new AncestralLandsCard(),
                            ContainedCard = firstPlayerStronghold
                        },
                        new Province
                        {
                            ProvinceCard = new ElementalFuryCard(),
                            ContainedCard = new MiyaMysticCard()
                        },
                        new Province
                        {
                            ProvinceCard = new FertileFieldsCard(),
                            ContainedCard = new MiyaMysticCard()
                        },
                        new Province
                        {
                            ProvinceCard = new KuroiMoriCard(),
                            ContainedCard = new MiyaMysticCard()
                        },
                        new Province()
                        {
                            ProvinceCard = new MeditationsOnTheTaoCard(),
                            ContainedCard = new MiyaMysticCard()
                        }
                    }
                },
                new Player()
            };

            var game = new CoreEngine.Game.Game(players);

            var gameState = game.GameState;
            gameState.Players.Should().HaveCount(2);
            var firstPlayer = gameState.Players.First(x => x.Id == firstPlayerId);
            firstPlayer.Stronghold.Should().BeOfType<IsawaMoriSeidoCard>();
            firstPlayer.Provinces.Should().HaveCount(5);
            firstPlayer.Provinces.Where(x => x.IsStrongholdProvince).Should().HaveCount(1);
        }
    }
}
