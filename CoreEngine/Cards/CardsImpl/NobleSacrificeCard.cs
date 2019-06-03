using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class NobleSacrificeCard : EventCard
    {
        public NobleSacrificeCard()
        {
            Name = "Noble Sacrifice";
            Clan = Clan.Crane;
            Cost = 1;
            Text = "<b>Action:</b> Sacrifice a <i>(friendly)</i> honored character. Choose a dishonored character – discard that character.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_148.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
