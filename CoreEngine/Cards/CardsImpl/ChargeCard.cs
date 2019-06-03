using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ChargeCard : EventCard
    {
        public ChargeCard()
        {
            Name = "Charge!";
            Clan = Clan.Neutral;
            Cost = 1;
            Text = "<b>Action:</b> During a [conflict-military] conflict, choose a character in one of your provinces – put that character into play in the conflict.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_210.jpg");
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
            IsRestricted = true;
            Side = Side.Conflict;
        }
    }
}
