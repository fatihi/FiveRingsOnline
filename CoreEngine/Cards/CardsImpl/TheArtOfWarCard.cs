using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TheArtOfWarCard : ProvinceCard
    {
        public TheArtOfWarCard()
        {
            Name = "The Art of War";
            Clan = Clan.Lion;
            Element = Element.Water;
            Strength = 3;
            Text = "<b>Interrupt:</b> When this province is broken – draw 3 cards.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_11.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
