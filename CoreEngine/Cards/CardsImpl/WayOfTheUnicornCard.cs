using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheUnicornCard : EventCard
    {
        public WayOfTheUnicornCard()
        {
            Name = "Way of the Unicorn";
            Clan = Clan.Unicorn;
            Cost = 0;
            Text = "<b>Interrupt:</b> When you would pass the first player token – keep it instead.";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_198.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
