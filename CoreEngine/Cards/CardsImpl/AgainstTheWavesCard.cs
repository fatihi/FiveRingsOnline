using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AgainstTheWavesCard : EventCard
    {
        public AgainstTheWavesCard()
        {
            Name = "Against the Waves";
            Clan = Clan.Phoenix;
            Cost = 1;
            Text = "<b>Action:</b> Choose a <em>Shugenja</em> character – bow or ready that character.";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Water
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_177.jpg");
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
