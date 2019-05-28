using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class AboveQuestionCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("above-question") as AttachmentCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Above Question");
            card.Type.Should().Be(CardType.Attachment);
            card.Cost.Should().Be(1);
            card.MilitaryBonus.Should().Be(0);
            card.PoliticalBonus.Should().Be(0);
            card.Clan.Should().Be(Clan.Crane);
        }
    }
}
