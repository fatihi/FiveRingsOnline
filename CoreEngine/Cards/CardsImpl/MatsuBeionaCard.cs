using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MatsuBeionaCard : CharacterCard
    {
        public MatsuBeionaCard()
        {
            Name = "Matsu Beiona";
            Clan = Clan.Lion;
            Cost = 3;
            Glory = 2;
            Military = 3;
            Political = 2;
            Text = "<b>Reaction:</b> After this character enters play, if you control 3 or more other <em>Bushi</em> characters – place 2 fate on this character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_76.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
