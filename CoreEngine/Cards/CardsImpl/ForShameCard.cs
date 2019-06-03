using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ForShameCard : EventCard
    {
        public ForShameCard()
        {
            Name = "For Shame!";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Action:</b> During a conflict, if you control a participating <em>Courtier</em> character, choose a participating character controlled by your opponent. Your opponent must select one – dishonor the chosen character or bow it.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_207.jpg");
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
