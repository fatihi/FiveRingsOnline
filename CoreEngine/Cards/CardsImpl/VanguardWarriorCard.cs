using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class VanguardWarriorCard : CharacterCard
    {
        public VanguardWarriorCard()
        {
            Name = "Vanguard Warrior";
            Clan = Clan.Crab;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 1;
            Text = "<b>Action:</b> Sacrifice this character. Choose a character – place 1 fate on that character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_30.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
