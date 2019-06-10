using CoreEngine.Cards;
using CoreEngine.Game;
using NUnit.Framework;

namespace UnitTests.Cards
{
    public class CardTests
    {
        [Test]
        public void OnCreate_ShouldNot_ChangeState()
        {
            var gameState = new GameState();
            var card = new Card();

            card.OnCreate(gameState);
        }
    }
}
