using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheLionCard : EventCard
    {
        public WayOfTheLionCard()
        {
            Name = "Way of the Lion";
            Clan = Clan.Lion;
            Cost = 0;
            Text = "<b>Action:</b> During a conflict, choose a [clan-lion] character – double that character's base [conflict-military] skill until the end of the conflict.";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_167.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
