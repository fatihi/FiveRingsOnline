using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FuneralPyreCard : HoldingCard
    {
        public FuneralPyreCard()
        {
            Name = "Funeral Pyre";
            Clan = Clan.Crab;
            StrengthBonus = 0;
            Text = "<b>Action:</b> Sacrifice a <i>(friendly)</i> character – draw 1 card.";
            Traits = new[] { Trait.Ritual };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_39.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
