using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AmbushCard : EventCard
    {
        public AmbushCard()
        {
            Name = "Ambush";
            Clan = Clan.Scorpion;
            Cost = 3;
            Text = "<b>Action:</b> During a conflict, choose up to 2 [clan-scorpion] characters with total printed cost 6 or lower from your hand and/or provinces – put those characters into play as participating characters.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_188.jpg");
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
