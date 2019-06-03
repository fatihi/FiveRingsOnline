using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ContingencyPlanCard : EventCard
    {
        public ContingencyPlanCard()
        {
            Name = "Contingency Plan";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Reaction:</b> After honor dials are revealed – increase or decrease the value of your bid by 1 <i>(to a minimum of 0)</i>.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_205.jpg");
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
