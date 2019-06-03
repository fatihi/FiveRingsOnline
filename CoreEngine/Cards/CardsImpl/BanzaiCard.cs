using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BanzaiCard : EventCard
    {
        public BanzaiCard()
        {
            Name = "Banzai!";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Action:</b> During a conflict, choose a participating character – that character gets +2[conflict-military] until the end of the conflict. You may lose 1 honor to resolve this ability twice. (Max 1 per conflict.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_204.jpg");
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
