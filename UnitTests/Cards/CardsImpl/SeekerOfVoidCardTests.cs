using CoreEngine.Cards;
using CoreEngine.Cards.CardsImpl;
using CoreEngine.Cards.CartTypes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards.CardsImpl
{
    [TestClass]
    public class SeekerOfVoidCardTests
    {
        [TestMethod]
        public void CardData_Should_BeSetCorrectly()
        {
            var instantiator = new CardInstantiator();

            var card = instantiator.CreateCard("seeker-of-void") as SeekerOfVoidCard;

            card.Should().NotBeNull();
            card.Name.Should().Be("Seeker of Void");
            card.Type.Should().Be(CardType.Role);
            card.RoleType.Should().Be(RoleType.Seeker);
            card.Element.Should().Be(Element.Void);
            card.Clan.Should().BeNull();
        }
    }
}
