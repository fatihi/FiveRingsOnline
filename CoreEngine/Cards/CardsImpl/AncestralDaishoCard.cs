using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AncestralDaishoCard : AttachmentCard
    {
        public AncestralDaishoCard()
        {
            Name = "Ancestral Daishō";
            Clan = Clan.Dragon;
            Cost = 1;
            MilitaryBonus = 2;
            PoliticalBonus = 0;
            Text = "Ancestral. <i>(When attached card leaves play, return this card to your hand.)</i>\nRestricted. <i>(No more than two restricted attachments per character.)</i>";
            Traits = new[] { Trait.Weapon };
            Keywords = new[]
            {
                Keyword.Ancestral,
                Keyword.Restricted
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_151.jpg");
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
