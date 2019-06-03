using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BlackmailCard : EventCard
    {
        public BlackmailCard()
        {
            Name = "Blackmail";
            Clan = Clan.Scorpion;
            Cost = 3;
            Text = "Play only if you are less honorable than your opponent.\n<b>Action:</b> During a conflict, choose a character with printed cost 2 or lower controlled by your opponent – take control of that character until the end of the conflict.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_189.jpg");
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
