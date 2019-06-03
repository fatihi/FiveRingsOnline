using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class UnassumingYojimboCard : CharacterCard
    {
        public UnassumingYojimboCard()
        {
            Name = "Unassuming Yōjimbō";
            Clan = Clan.Scorpion;
            Cost = 3;
            Glory = 0;
            Military = 3;
            Political = 1;
            Text = "Covert. <i>(When this character attacks, choose one character without covert. That character cannot be declared as a defender.)</i>";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Yojimbo
            };
            Keywords = new[] { Keyword.Covert };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_181.jpg");
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
