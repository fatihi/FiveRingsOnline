using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class KuroiMoriCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("kuroi-mori") as ProvinceCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Kuroi Mori");
            card.Type.Should().Be(CardType.Province);
            card.Element.Should().Be(Element.Void);
            card.Strength.Should().Be(4);
        }
    }
}
