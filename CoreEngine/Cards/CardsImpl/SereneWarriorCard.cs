using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SereneWarriorCard : CharacterCard
    {
        public SereneWarriorCard()
        {
            Name = "Serene Warrior";
            Clan = Clan.Phoenix;
            Cost = 3;
            Glory = 4;
            Military = 3;
            Political = 2;
            Text = null;
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_88.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
