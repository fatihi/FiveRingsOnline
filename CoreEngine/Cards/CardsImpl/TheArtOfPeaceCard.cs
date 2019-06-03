using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TheArtOfPeaceCard : ProvinceCard
    {
        public TheArtOfPeaceCard()
        {
            Name = "The Art of Peace";
            Clan = Clan.Crane;
            Element = Element.Air;
            Strength = 4;
            Text = "<b>Interrupt:</b> When this province is broken – dishonor each attacking character and honor each defending character.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_9.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
