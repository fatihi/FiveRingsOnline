using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AboveQuestionCard : AttachmentCard
    {
        public AboveQuestionCard()
        {
            Name = "Above Question";
            Clan = Clan.Crane;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "Attached character cannot be chosen as a target of an opponent's event.";
            Traits = new[] { Trait.Condition };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_141.jpg");
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
