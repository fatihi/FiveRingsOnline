using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DefendTheWallCard : ProvinceCard
    {
        public DefendTheWallCard()
        {
            Name = "Defend the Wall";
            Clan = Clan.Crab;
            Element = Element.Earth;
            Strength = 4;
            Text = "<b>Reaction:</b> After you win a conflict at this province – resolve the ring effect of that conflict as if you were the attacking player.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_8.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
