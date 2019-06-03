using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TheMountainDoesNotFallCard : EventCard
    {
        public TheMountainDoesNotFallCard()
        {
            Name = "The Mountain Does Not Fall";
            Clan = Clan.Crab;
            Cost = 1;
            Text = "<b>Action:</b> Choose a character – until the end of the phase, that character does not bow as a result of conflict resolution while defending. (Max 1 per round.)";
            Traits = new[] { Trait.Technique };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_138.jpg");
            AllowedClans = new[]
            {
                Clan.Crab,
                Clan.Crane,
                Clan.Dragon,
                Clan.Lion,
                Clan.Phoenix,
                Clan.Scorpion,
                Clan.Unicorn
            };
            DeckLimit = 3;
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
