using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheScorpionCard : EventCard
    {
        public WayOfTheScorpionCard()
        {
            Name = "Way of the Scorpion";
            Clan = Clan.Scorpion;
            Cost = 0;
            Text = "<b>Action:</b> During a conflict, choose a participating non-[clan-scorpion] character – dishonor that character.";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_185.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
