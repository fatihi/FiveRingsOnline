using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BornInWarCard : AttachmentCard
    {
        public BornInWarCard()
        {
            Name = "Born in War";
            Clan = Clan.Unicorn;
            Cost = 2;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "<em>Cavalry</em> character only.\nX is equal to the number of unclaimed rings.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_194.jpg");
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
