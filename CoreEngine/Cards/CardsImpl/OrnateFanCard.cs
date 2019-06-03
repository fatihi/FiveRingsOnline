using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class OrnateFanCard : AttachmentCard
    {
        public OrnateFanCard()
        {
            Name = "Ornate Fan";
            Clan = Clan.Neutral;
            Cost = 0;
            MilitaryBonus = 0;
            PoliticalBonus = 2;
            Text = "Restricted. <i>(No more than two restricted attachments per character.)</i>";
            Traits = new[] { Trait.Item };
            Keywords = new[] { Keyword.Restricted };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_201.jpg");
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
            InfluenceCost = 0;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
