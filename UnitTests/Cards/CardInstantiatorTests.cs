using CoreEngine.Cards;
using CoreEngine.Cards.CardsImpl;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards
{
    [TestClass]
    public class CardInstantiatorTests
    {
        [TestMethod]
        public void CreateCard_Should_CreateInstanceOfCard_When_GivenId()
        {
            const string cardId = "way-of-the-phoenix";
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard(cardId);

            card.GetType().Should().Be(typeof(WayOfThePhoenixCard));
            card.CardId.Should().Be(cardId);
        }

        [TestMethod]
        public void CreateCard_Should_CreateInstanceOfCard_When_GivenDifferentId()
        {
            const string cardId = "way-of-the-dragon";
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard(cardId);

            card.GetType().Should().Be(typeof(WayOfTheDragonCard));
            card.CardId.Should().Be(cardId);
        }
    }
}
