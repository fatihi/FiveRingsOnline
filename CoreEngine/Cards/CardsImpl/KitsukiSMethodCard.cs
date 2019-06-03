using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KitsukiSMethodCard : AttachmentCard
    {
        public KitsukiSMethodCard()
        {
            Name = "Kitsuki's Method";
            Clan = Clan.Dragon;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 2;
            Text = "Ancestral. <i>(When attached card leaves play, return this card to your hand.)</i>\nRestricted. <i>(No more than two restricted attachments per character.)</i>";
            Traits = new[] { Trait.Technique };
            Keywords = new[]
            {
                Keyword.Ancestral,
                Keyword.Restricted
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_153.jpg");
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
