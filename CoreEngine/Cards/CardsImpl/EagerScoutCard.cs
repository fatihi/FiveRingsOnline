using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class EagerScoutCard : CharacterCard
    {
        public EagerScoutCard()
        {
            Name = "Eager Scout";
            Clan = Clan.Crab;
            Cost = 0;
            Glory = 0;
            Military = 0;
            Political = 0;
            Text = null;
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_25.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
