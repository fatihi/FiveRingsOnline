using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AssassinationCard : EventCard
    {
        public AssassinationCard()
        {
            Name = "Assassination";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Action:</b> During a conflict, lose 3 honor. Choose a character with printed cost 2 or lower – discard that character. (Max 1 per round.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_203.jpg");
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
