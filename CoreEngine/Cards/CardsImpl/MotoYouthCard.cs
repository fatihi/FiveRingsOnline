using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MotoYouthCard : CharacterCard
    {
        public MotoYouthCard()
        {
            Name = "Moto Youth";
            Clan = Clan.Unicorn;
            Cost = 1;
            Glory = 1;
            Military = 2;
            Political = 0;
            Text = "This character gets +1[conflict-military] during the first [conflict-military] conflict each round.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_109.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
