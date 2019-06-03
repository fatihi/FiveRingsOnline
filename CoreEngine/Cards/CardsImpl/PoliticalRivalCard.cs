using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class PoliticalRivalCard : CharacterCard
    {
        public PoliticalRivalCard()
        {
            Name = "Political Rival";
            Clan = Clan.Crane;
            Cost = 3;
            Glory = 0;
            Military = null;
            Political = 3;
            Text = "Covert. <i>(When this character attacks, choose one character without covert. That character cannot be declared as a defender.)</i>\nThis character gets +3[conflict-political] while defending.";
            Traits = new[] { Trait.Courtier };
            Keywords = new[] { Keyword.Covert };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_140.jpg");
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
