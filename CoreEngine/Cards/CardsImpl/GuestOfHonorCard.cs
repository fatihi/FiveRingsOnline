using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GuestOfHonorCard : CharacterCard
    {
        public GuestOfHonorCard()
        {
            Name = "Guest of Honor";
            Clan = Clan.Crane;
            Cost = 4;
            Glory = 1;
            Military = 1;
            Political = 4;
            Text = "While this character is participating in a conflict, opponents cannot play events.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_51.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = true;
            Side = Side.Dynasty;
        }
    }
}
