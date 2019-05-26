using CoreEngine.Cards;
using CoreEngine.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Cards
{
    [TestClass]
    class CardTests
    {
        [TestMethod]
        public void OnCreate_ShouldNot_ChangeState()
        {
            var gameState = new GameState();
            var card = new Card();

            card.OnCreate(gameState);
        }
    }
}
