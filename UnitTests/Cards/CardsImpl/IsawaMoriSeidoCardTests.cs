using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class IsawaMoriSeidoCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("isawa-mori-seido") as StrongholdCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Isawa Mori Seidō");
            card.Type.Should().Be(CardType.Stronghold);
            card.Honor.Should().Be(11);
            card.InfluencePool.Should().Be(10);
            card.Fate.Should().Be(7);
            card.StrengthBonus.Should().Be(2);
        }
    }
}