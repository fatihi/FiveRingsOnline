using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GuidanceOfTheAncestorsCard : AttachmentCard
    {
        public GuidanceOfTheAncestorsCard()
        {
            Name = "Guidance of the Ancestors";
            Clan = Clan.Lion;
            Cost = 1;
            MilitaryBonus = 1;
            PoliticalBonus = 1;
            Text = "<b>Action:</b> Play this attachment from your conflict discard pile.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_162.jpg");
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
