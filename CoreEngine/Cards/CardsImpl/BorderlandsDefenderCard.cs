using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BorderlandsDefenderCard : CharacterCard
    {
        public BorderlandsDefenderCard()
        {
            Name = "Borderlands Defender";
            Clan = Clan.Crab;
            Cost = 3;
            Glory = 1;
            Military = 3;
            Political = 3;
            Text = "While this character is defending, opponents' card effects cannot bow it or move it.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_31.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
