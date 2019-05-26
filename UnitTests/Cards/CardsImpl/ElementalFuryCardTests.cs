using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class ElementalFuryCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("elemental-fury") as ProvinceCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Elemental Fury");
            card.Type.Should().Be(CardType.Province);
            card.Element.Should().Be(Element.Water);
            card.Strength.Should().Be(4);
        }
    }
}
