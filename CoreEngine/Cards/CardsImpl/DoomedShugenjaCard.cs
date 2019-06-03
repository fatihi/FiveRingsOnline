using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DoomedShugenjaCard : CharacterCard
    {
        public DoomedShugenjaCard()
        {
            Name = "Doomed Shugenja";
            Clan = Clan.Dragon;
            Cost = 1;
            Glory = 0;
            Military = 3;
            Political = 3;
            Text = "Limited. <i>(No more than one limited card can be played by each player each round.)</i>\nYou cannot place fate on this character when it is played from one of your provinces.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Fire
            };
            Keywords = new[] { Keyword.Limited };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_54.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
