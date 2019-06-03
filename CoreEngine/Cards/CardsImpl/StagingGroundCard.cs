using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class StagingGroundCard : HoldingCard
    {
        public StagingGroundCard()
        {
            Name = "Staging Ground";
            Clan = Clan.Lion;
            StrengthBonus = 1;
            Text = "<b>Action:</b> Choose up to 2 facedown cards in your provinces – turn the chosen cards faceup.";
            Traits = new[] { Trait.Battlefield };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_80.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
