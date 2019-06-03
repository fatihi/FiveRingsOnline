using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IkomaEijiCard : CharacterCard
    {
        public IkomaEijiCard()
        {
            Name = "Ikoma Eiji";
            Clan = Clan.Lion;
            Cost = 4;
            Glory = 3;
            Military = 1;
            Political = 3;
            Text = "<b>Reaction:</b> After you lose a [conflict-political] conflict – put a <em>Bushi</em> character with printed cost 3 or lower into play from your dynasty discard pile or provinces.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_78.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
