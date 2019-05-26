using System;
using System.Collections.Generic;
using CoreEngine.Cards.CartTypes;
using CoreEngine.Game;

namespace CoreEngine.Cards
{
    public class Card
    {
        public string CardId { get; set; }

        public Guid Id { get; set; }

        public CardType Type { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public void OnCreate(GameState gameState) { }

        public void OnPlay(GameState gameState) { }

        public void OnDestroy(GameState gameState) { }
    }
}
