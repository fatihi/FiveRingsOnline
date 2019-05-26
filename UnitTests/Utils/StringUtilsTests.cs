using CoreEngine.Utils;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Utils
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        [DataRow("banzai", "BanzaiCard")]
        [DataRow("way-of-the-phoenix", "WayOfThePhoenixCard")]
        public void GetCardNameFromId_Should_GenerateNameFromId(string cardId, string expectedName)
        {
            var cardName = StringUtils.GetCardNameFromId(cardId);
            
            cardName.Should().Be(expectedName);
        }
    }
}
