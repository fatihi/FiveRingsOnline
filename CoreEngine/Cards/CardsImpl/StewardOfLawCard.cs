using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class StewardOfLawCard : CharacterCard
    {
        public StewardOfLawCard()
        {
            Name = "Steward of Law";
            Clan = Clan.Crane;
            Cost = 1;
            Glory = 0;
            Military = 1;
            Political = 1;
            Text = "While this character is participating in a conflict, characters cannot become dishonored.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Scholar
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_139.jpg");
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
            IsRestricted = true;
            Side = Side.Conflict;
        }
    }
}
