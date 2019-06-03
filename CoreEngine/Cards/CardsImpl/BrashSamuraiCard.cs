using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BrashSamuraiCard : CharacterCard
    {
        public BrashSamuraiCard()
        {
            Name = "Brash Samurai";
            Clan = Clan.Crane;
            Cost = 2;
            Glory = 2;
            Military = 2;
            Political = 1;
            Text = "<b>Action:</b> While this character is your only participating character in a conflict – honor this character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_42.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
