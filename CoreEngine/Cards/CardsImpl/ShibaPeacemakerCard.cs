using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShibaPeacemakerCard : CharacterCard
    {
        public ShibaPeacemakerCard()
        {
            Name = "Shiba Peacemaker";
            Clan = Clan.Phoenix;
            Cost = 1;
            Glory = 1;
            Military = 4;
            Political = 1;
            Text = "This character cannot participate in conflicts as an attacker.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_82.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
