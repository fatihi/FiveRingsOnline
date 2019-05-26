using System.Linq;
using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using CoreEngine.Game;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class WayOfThePhoenixCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("way-of-the-phoenix") as EventCard;

            card.Should().NotBeNull();
            card.Cost.Should().Be(0);
            card.Type.Should().Be(CardType.Event);
        }

        [TestMethod]
        public void LegalTargets_Should_ReturnValidTargets()
        {
            var gameState = new GameState { };
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("way-of-the-phoenix") as EventCard;

            card.Actions.Should().HaveCount(1);
        }
    }
}