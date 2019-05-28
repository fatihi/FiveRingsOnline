using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class MiyaMysticCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("miya-mystic") as CharacterCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Miya Mystic");
            card.Type.Should().Be(CardType.Character);
            card.Clan.Should().Be(Clan.Neutral);
            card.Cost.Should().Be(2);
            card.Glory.Should().Be(1);
            card.Military.Should().Be(1);
            card.Political.Should().Be(1);
        }
    }
}
