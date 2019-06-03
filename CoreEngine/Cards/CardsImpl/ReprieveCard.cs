using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ReprieveCard : AttachmentCard
    {
        public ReprieveCard()
        {
            Name = "Reprieve";
            Clan = Clan.Crab;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "<b>Interrupt:</b> When attached character would leave play – discard this attachment instead.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_132.jpg");
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
