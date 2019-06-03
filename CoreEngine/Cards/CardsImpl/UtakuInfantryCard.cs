using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class UtakuInfantryCard : CharacterCard
    {
        public UtakuInfantryCard()
        {
            Name = "Utaku Infantry";
            Clan = Clan.Unicorn;
            Cost = 1;
            Glory = 1;
            Military = 0;
            Political = 0;
            Text = "While this character is participating in a conflict, it gets +1[conflict-military] and +1[conflict-political] for each participating [clan-unicorn] character you control.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_110.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
