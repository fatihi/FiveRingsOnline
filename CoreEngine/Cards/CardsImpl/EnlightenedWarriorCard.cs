using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class EnlightenedWarriorCard : CharacterCard
    {
        public EnlightenedWarriorCard()
        {
            Name = "Enlightened Warrior";
            Clan = Clan.Dragon;
            Cost = 3;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "<b>Reaction:</b> After an opponent selects a ring with fate on it – place 1 fate on this character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_60.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
