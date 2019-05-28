using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class AdmitDefeatCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("admit-defeat") as EventCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Admit Defeat");
            card.Clan.Should().Be(Clan.Crane);
            card.Cost.Should().Be(1);
            card.Text.Should().Be("<b>Action:</b> Choose a character that is defending alone – bow that character.");
            card.Traits.Should().HaveCount(0);
            card.IsUnique.Should().BeFalse();
            card.Type.Should().Be(CardType.Event);
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
