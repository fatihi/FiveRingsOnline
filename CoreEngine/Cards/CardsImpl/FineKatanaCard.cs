using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FineKatanaCard : AttachmentCard
    {
        public FineKatanaCard()
        {
            Name = "Fine Katana";
            Clan = Clan.Neutral;
            Cost = 0;
            MilitaryBonus = 2;
            PoliticalBonus = 0;
            Text = "Restricted. <i>(No more than two restricted attachments per character.)</i>";
            Traits = new[] { Trait.Weapon };
            Keywords = new[] { Keyword.Restricted };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_200.jpg");
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
