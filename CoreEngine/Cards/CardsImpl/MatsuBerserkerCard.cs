using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MatsuBerserkerCard : CharacterCard
    {
        public MatsuBerserkerCard()
        {
            Name = "Matsu Berserker";
            Clan = Clan.Lion;
            Cost = 1;
            Glory = 1;
            Military = 3;
            Political = null;
            Text = null;
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Berserker
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_69.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
