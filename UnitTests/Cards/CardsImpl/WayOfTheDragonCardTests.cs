using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class WayOfTheDragonCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("way-of-the-dragon") as AttachmentCard;

            card.Should().NotBeNull();
            card.Cost.Should().Be(2);
            card.Type.Should().Be(CardType.Attachment);
            card.MilitaryBonus.Should().Be(1);
            card.PoliticalBonus.Should().Be(1);
        }
    }
}