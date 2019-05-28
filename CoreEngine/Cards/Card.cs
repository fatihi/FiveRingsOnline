using System;
using System.Collections.Generic;
using CoreEngine.Cards.CartTypes;
using CoreEngine.Game;

namespace CoreEngine.Cards
{
    public class Card
    {
        public Guid Id { get; set; }

        public string CardId { get; set; }
        public string Name { get; set; }
        public virtual CardType Type { get; set; }
        public string Text { get; set; }
        public bool IsUnique { get; set; }
        public IEnumerable<Trait> Traits { get; set; }

        public Uri ImageUrl { get; set; }

        public IEnumerable<Clan> AllowedClans { get; set; }
        public int DeckLimit { get; set; }
        public bool IsRestricted { get; set; }
        public Side Side { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public void OnCreate(GameState gameState) { }

        public void OnPlay(GameState gameState) { }

        public void OnDestroy(GameState gameState) { }
    }
}
