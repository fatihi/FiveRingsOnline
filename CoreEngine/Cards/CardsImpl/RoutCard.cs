using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class RoutCard : EventCard
    {
        public RoutCard()
        {
            Name = "Rout";
            Clan = Clan.Neutral;
            Cost = 1;
            Text = "<b>Action:</b> During a conflict, choose an opponent's character with lower [conflict-military] skill than a participating <em>Bushi</em> character you control – move the chosen character home.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_213.jpg");
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
            InfluenceCost = 0;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
