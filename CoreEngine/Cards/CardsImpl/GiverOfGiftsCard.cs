using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GiverOfGiftsCard : CharacterCard
    {
        public GiverOfGiftsCard()
        {
            Name = "Giver of Gifts";
            Clan = Clan.Unicorn;
            Cost = 3;
            Glory = 2;
            Military = 2;
            Political = 3;
            Text = "<b>Action:</b> Choose an attachment you control – move that attachment to an eligible character you control.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_115.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
