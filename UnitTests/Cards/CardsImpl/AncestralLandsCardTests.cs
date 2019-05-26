using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class AncestralLandsCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("ancestral-lands") as ProvinceCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Ancestral Lands");
            card.Type.Should().Be(CardType.Province);
            card.Element.Should().Be(Element.Earth);
            card.Strength.Should().Be(5);
        }
    }
}
