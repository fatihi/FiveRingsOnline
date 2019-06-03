using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FieryMadnessCard : AttachmentCard
    {
        public FieryMadnessCard()
        {
            Name = "Fiery Madness";
            Clan = Clan.Scorpion;
            Cost = 1;
            MilitaryBonus = -2;
            PoliticalBonus = -2;
            Text = null;
            Traits = new[] { Trait.Poison };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_183.jpg");
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
