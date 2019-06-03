using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AggressiveMotoCard : CharacterCard
    {
        public AggressiveMotoCard()
        {
            Name = "Aggressive Moto";
            Clan = Clan.Unicorn;
            Cost = 2;
            Glory = 0;
            Military = 3;
            Political = 0;
            Text = "This character cannot be declared as a defender.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_111.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
