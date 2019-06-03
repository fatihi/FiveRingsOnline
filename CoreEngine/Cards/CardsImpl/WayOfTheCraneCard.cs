using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheCraneCard : EventCard
    {
        public WayOfTheCraneCard()
        {
            Name = "Way of the Crane";
            Clan = Clan.Crane;
            Cost = 0;
            Text = "<b>Action:</b> Choose a [clan-crane] character you control – honor that character.";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_146.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
