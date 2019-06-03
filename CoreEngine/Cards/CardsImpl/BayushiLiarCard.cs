using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BayushiLiarCard : CharacterCard
    {
        public BayushiLiarCard()
        {
            Name = "Bayushi Liar";
            Clan = Clan.Scorpion;
            Cost = 1;
            Glory = 0;
            Military = null;
            Political = 3;
            Text = "Sincerity. <i>(When this character leaves play, draw 1 card.)</i>";
            Traits = new[] { Trait.Courtier };
            Keywords = new[] { Keyword.Sincerity };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_95.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
