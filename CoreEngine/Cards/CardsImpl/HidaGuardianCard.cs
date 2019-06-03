using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HidaGuardianCard : CharacterCard
    {
        public HidaGuardianCard()
        {
            Name = "Hida Guardian";
            Clan = Clan.Crab;
            Cost = 1;
            Glory = 1;
            Military = 1;
            Political = 1;
            Text = "<b>Action:</b> While this character is participating in a conflict, choose another participating character – until the end of the conflict, that character gets +2[conflict-military] and +2[conflict-political] for each holding you control.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_26.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
