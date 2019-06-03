using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IntimidatingHidaCard : CharacterCard
    {
        public IntimidatingHidaCard()
        {
            Name = "Intimidating Hida";
            Clan = Clan.Crab;
            Cost = 3;
            Glory = 1;
            Military = 4;
            Political = 2;
            Text = "<b>Reaction:</b> After an opponent passes on declaring a conflict – that player loses 1 honor.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_32.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
