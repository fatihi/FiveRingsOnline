using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MagnificentKimonoCard : AttachmentCard
    {
        public MagnificentKimonoCard()
        {
            Name = "Magnificent Kimono";
            Clan = Clan.Phoenix;
            Cost = 0;
            MilitaryBonus = 0;
            PoliticalBonus = 1;
            Text = "Attached character gains pride. <i>(After this character wins a conflict, honor it. After this character loses a conflict, dishonor it.)</i>";
            Traits = new[] { Trait.Item };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_172.jpg");
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
