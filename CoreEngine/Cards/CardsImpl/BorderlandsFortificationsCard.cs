using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BorderlandsFortificationsCard : HoldingCard
    {
        public BorderlandsFortificationsCard()
        {
            Name = "Borderlands Fortifications";
            Clan = Clan.Crab;
            StrengthBonus = 2;
            Text = "<b>Action:</b> Choose a card in one of your provinces – switch this holding with that card.";
            Traits = new[] { Trait.Battlefield };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_38.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
