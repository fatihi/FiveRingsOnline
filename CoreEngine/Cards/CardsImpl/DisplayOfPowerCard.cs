using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DisplayOfPowerCard : EventCard
    {
        public DisplayOfPowerCard()
        {
            Name = "Display of Power";
            Clan = Clan.Phoenix;
            Cost = 2;
            Text = "<b>Reaction:</b> After you lose an unopposed conflict – cancel the ring effect of that conflict. Then, you resolve that ring effect as if you had won the conflict as the attacking player. Claim that ring.";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Fire
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_179.jpg");
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
