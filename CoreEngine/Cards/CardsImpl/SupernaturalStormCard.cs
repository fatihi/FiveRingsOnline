using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SupernaturalStormCard : EventCard
    {
        public SupernaturalStormCard()
        {
            Name = "Supernatural Storm";
            Clan = Clan.Phoenix;
            Cost = 0;
            Text = "<b>Action:</b> Choose a participating character – that character gets +X[conflict-military] and +X[conflict-political] until the end of the conflict. X is equal to the number of <em>Shugenja</em> characters you control.";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Water
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_175.jpg");
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
