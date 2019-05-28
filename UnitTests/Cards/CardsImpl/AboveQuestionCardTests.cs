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
            card.Clan.Should().Be(Clan.Crane);
            card.Cost.Should().Be(1);
            card.MilitaryBonus.Should().Be(0);
            card.PoliticalBonus.Should().Be(0);
            card.Text.Should().Be("Attached character cannot be chosen as a target of an opponent's event.");
            card.Traits.Should().HaveCount(1);
            card.Traits.Should().Contain(Trait.Condition);
            card.IsUnique.Should().BeFalse();
            card.Type.Should().Be(CardType.Attachment);
            card.ImageUrl.Should().Be("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_141.jpg");
            card.AllowedClans.Should().HaveCount(7);
            card.AllowedClans.Should().Contain(Clan.Crab);
            card.AllowedClans.Should().Contain(Clan.Crane);
            card.AllowedClans.Should().Contain(Clan.Dragon);
            card.AllowedClans.Should().Contain(Clan.Lion);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.DeckLimit.Should().Be(3);
            card.InfluenceCost.Should().Be(2);
            card.IsRestricted.Should().BeFalse();
            card.Side.Should().Be(Side.Conflict);
        }
    }
}
