using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CavalryReservesCard : EventCard
    {
        public CavalryReservesCard()
        {
            Name = "Cavalry Reserves";
            Clan = Clan.Unicorn;
            Cost = 3;
            Text = "<b>Action:</b> During a [conflict-military] conflict, choose up to 6 printed cost worth of <em>Cavalry</em> characters in your dynasty discard pile – put those characters into play in the conflict.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_199.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
