using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class FertileFieldsCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("fertile-fields") as ProvinceCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Fertile Fields");
            card.Type.Should().Be(CardType.Province);
            card.Element.Should().Be(Element.Air);
            card.Strength.Should().Be(4);
        }
    }
}
