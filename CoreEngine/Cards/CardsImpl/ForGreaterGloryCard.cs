using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ForGreaterGloryCard : EventCard
    {
        public ForGreaterGloryCard()
        {
            Name = "For Greater Glory";
            Clan = Clan.Lion;
            Cost = 1;
            Text = "<b>Reaction:</b> After you break a province during a [conflict-military] conflict – place 1 fate on each participating <em>Bushi</em> character you control. (Max 1 per conflict.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_168.jpg");
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
            IsRestricted = true;
            Side = Side.Conflict;
        }
    }
}
