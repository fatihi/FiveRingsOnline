using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KaiuEnvoyCard : CharacterCard
    {
        public KaiuEnvoyCard()
        {
            Name = "Kaiu Envoy";
            Clan = Clan.Crab;
            Cost = 1;
            Glory = 1;
            Military = 1;
            Political = 0;
            Text = "Courtesy. <i>(When this character leaves play, gain 1 fate.)</i>\nSincerity. <i>(When this character leaves play, draw 1 card.)</i>";
            Traits = new[] { Trait.Bushi };
            Keywords = new[]
            {
                Keyword.Courtesy,
                Keyword.Sincerity
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_27.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
