using CoreEngine.Cards;
using CoreEngine.Cards.CardsImpl;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests.Cards
{
    public class CardInstantiatorTests
    {
        [Test]
        public void CreateCard_Should_CreateInstanceOfCard_When_GivenId()
        {
            const string cardId = "way-of-the-phoenix";
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard(cardId);

            card.GetType().Should().Be(typeof(WayOfThePhoenixCard));
            card.CardId.Should().Be(cardId);
        }

        [Test]
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
