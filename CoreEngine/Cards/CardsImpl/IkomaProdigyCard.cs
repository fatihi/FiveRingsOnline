using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IkomaProdigyCard : CharacterCard
    {
        public IkomaProdigyCard()
        {
            Name = "Ikoma Prodigy";
            Clan = Clan.Lion;
            Cost = 1;
            Glory = 1;
            Military = 0;
            Political = 2;
            Text = "<b>Reaction:</b> After 1 or more fate is placed on this character – gain 1 honor.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_68.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
