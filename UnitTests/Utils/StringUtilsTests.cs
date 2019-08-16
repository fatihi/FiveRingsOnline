using CoreEngine.Utils;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests.Utils
{
    public class StringUtilsTests
    {
        [TestCase("banzai", "BanzaiCard")]
        [TestCase("way-of-the-phoenix", "WayOfThePhoenixCard")]
        public void GetCardNameFromId_Should_GenerateNameFromId(string cardId, string expectedName)
        {
            var cardName = StringUtils.GetCardNameFromCardId(cardId);
            
            cardName.Should().Be(expectedName);
        }
    }
}
