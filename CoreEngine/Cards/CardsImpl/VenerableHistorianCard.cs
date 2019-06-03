using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class VenerableHistorianCard : CharacterCard
    {
        public VenerableHistorianCard()
        {
            Name = "Venerable Historian";
            Clan = Clan.Lion;
            Cost = 2;
            Glory = 3;
            Military = null;
            Political = 1;
            Text = "<b>Action:</b> While this character is participating in a conflict, if you are more honorable than your opponent – honor this character.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Scholar
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_73.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
