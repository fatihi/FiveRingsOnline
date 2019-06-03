using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WarriorPoetCard : CharacterCard
    {
        public WarriorPoetCard()
        {
            Name = "Warrior Poet";
            Clan = Clan.Unicorn;
            Cost = 3;
            Glory = 2;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict – each participating character controlled by your opponent gets –1[conflict-military] and –1[conflict-political] until the end of the conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_117.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
