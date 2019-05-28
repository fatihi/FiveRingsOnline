using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class AdeptOfTheWavesCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("adept-of-the-waves") as CharacterCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Adept of the Waves");
            card.Clan.Should().Be(Clan.Phoenix);
            card.Cost.Should().Be(2);
            card.Glory.Should().Be(2);
            card.Military.Should().Be(2);
            card.Political.Should().Be(2);
            card.Text.Should().Be("<b>Action:</b> Choose a character – until the end of the phase, that character gains covert during [element-water] conflicts.");
            card.Traits.Should().HaveCount(2);
            card.Traits.Should().Contain(Trait.Shugenja);
            card.Traits.Should().Contain(Trait.Water);
            card.IsUnique.Should().BeFalse();
            card.Type.Should().Be(CardType.Character);
            card.ImageUrl.Should().Be("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_84.jpg");
            card.AllowedClans.Should().HaveCount(1);
            card.AllowedClans.Should().Contain(Clan.Phoenix);
            card.DeckLimit.Should().Be(3);
            card.InfluenceCost.Should().BeNull();
            card.IsRestricted.Should().BeFalse();
            card.Side.Should().Be(Side.Dynasty);
        }
    }
}
