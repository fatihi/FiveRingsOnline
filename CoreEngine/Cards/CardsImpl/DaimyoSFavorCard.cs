using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DaimyoSFavorCard : AttachmentCard
    {
        public DaimyoSFavorCard()
        {
            Name = "Daimyō's Favor";
            Clan = Clan.Dragon;
            Cost = 0;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "Attach to a character you control.\n<b>Action:</b> Bow this attachment – reduce the cost of the next attachment you play on this character this phase by 1.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_152.jpg");
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
