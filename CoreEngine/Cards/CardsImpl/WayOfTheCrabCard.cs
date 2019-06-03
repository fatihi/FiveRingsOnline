using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheCrabCard : EventCard
    {
        public WayOfTheCrabCard()
        {
            Name = "Way of the Crab";
            Clan = Clan.Crab;
            Cost = 1;
            Text = "<b>Action:</b> Sacrifice a <i>(friendly)</i> [clan-crab] character. Choose an opponent – that player must sacrifice a character. (Max 1 per round.)";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_137.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
