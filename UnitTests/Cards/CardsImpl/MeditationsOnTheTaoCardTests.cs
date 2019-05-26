using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class MeditationsOnTheTaoCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("meditations-on-the-tao") as ProvinceCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Meditations on the Tao");
            card.Type.Should().Be(CardType.Province);
            card.Element.Should().Be(Element.Fire);
            card.Strength.Should().Be(4);
        }
    }
}
