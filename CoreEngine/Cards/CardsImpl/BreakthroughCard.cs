using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BreakthroughCard : EventCard
    {
        public BreakthroughCard()
        {
            Name = "Breakthrough";
            Clan = Clan.Unicorn;
            Cost = 0;
            Text = "<b>Reaction:</b> After the resolution of your first conflict this phase as the attacking player, if that conflict broke a province – immediately declare your second conflict for this phase.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_195.jpg");
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
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
