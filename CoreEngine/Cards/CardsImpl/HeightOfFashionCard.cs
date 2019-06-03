using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HeightOfFashionCard : AttachmentCard
    {
        public HeightOfFashionCard()
        {
            Name = "Height of Fashion";
            Clan = Clan.Crane;
            Cost = 2;
            MilitaryBonus = 0;
            PoliticalBonus = 4;
            Text = "This attachment cannot be played during a conflict.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_143.jpg");
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
