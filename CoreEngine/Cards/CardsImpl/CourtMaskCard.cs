using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CourtMaskCard : AttachmentCard
    {
        public CourtMaskCard()
        {
            Name = "Court Mask";
            Clan = Clan.Scorpion;
            Cost = 1;
            MilitaryBonus = 1;
            PoliticalBonus = 2;
            Text = "Attach to a character you control.\n<b>Action:</b> Return this attachment to your hand and dishonor attached character.";
            Traits = new[]
            {
                Trait.Item,
                Trait.Mask
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_182.jpg");
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
