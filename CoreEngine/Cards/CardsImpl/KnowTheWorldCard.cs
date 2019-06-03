using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KnowTheWorldCard : EventCard
    {
        public KnowTheWorldCard()
        {
            Name = "Know the World";
            Clan = Clan.Phoenix;
            Cost = 1;
            Text = "<b>Action:</b> Switch a ring in your claimed ring pool with an unclaimed ring and gain all fate on that ring. <i>(Retain the ring's conflict type.)</i>";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Void
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_178.jpg");
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
