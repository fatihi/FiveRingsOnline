using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class AdeptOfShadowsCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("adept-of-shadows") as CharacterCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Adept of Shadows");
            card.Clan.Should().Be(Clan.Scorpion);
            card.Cost.Should().Be(2);
            card.Glory.Should().Be(0);
            card.Military.Should().Be(2);
            card.Political.Should().Be(2);
            card.Text.Should().Be("<b>Action:</b> Lose 1 honor – return this character to your hand.");
            card.Traits.Should().HaveCount(2);
            card.Traits.Should().Contain(Trait.Bushi);
            card.Traits.Should().Contain(Trait.Shinobi);
            card.IsUnique.Should().BeFalse();
            card.Type.Should().Be(CardType.Character);
            card.AllowedClans.Should().HaveCount(7);
            card.AllowedClans.Should().Contain(Clan.Crab);
            card.AllowedClans.Should().Contain(Clan.Crane);
            card.AllowedClans.Should().Contain(Clan.Dragon);
            card.AllowedClans.Should().Contain(Clan.Lion);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.AllowedClans.Should().Contain(Clan.Scorpion);
            card.AllowedClans.Should().Contain(Clan.Unicorn);
            card.DeckLimit.Should().Be(3);
            card.InfluenceCost.Should().Be(3);
            card.IsRestricted.Should().BeFalse();
            card.Side.Should().Be(Side.Conflict);
        }
    }
}
