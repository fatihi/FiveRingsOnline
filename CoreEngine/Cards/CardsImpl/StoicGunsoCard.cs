using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class StoicGunsoCard : CharacterCard
    {
        public StoicGunsoCard()
        {
            Name = "Stoic Gunsō";
            Clan = Clan.Crab;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 1;
            Text = "<b>Action:</b> During a conflict, sacrifice a <i>(friendly)</i> character – this character gets +3[conflict-military] until the end of the conflict.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_131.jpg");
            AllowedClans = new[]
            {
                Clan.Crab,
                Clan.Crane,
                Clan.Dragon,
                Clan.Lion,
                Clan.Phoenix,
                Clan.Scorpion,
                Clan.Unicorn
            };
            DeckLimit = 3;
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
