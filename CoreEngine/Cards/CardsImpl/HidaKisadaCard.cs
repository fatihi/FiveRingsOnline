using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HidaKisadaCard : CharacterCard
    {
        public HidaKisadaCard()
        {
            Name = "Hida Kisada";
            Clan = Clan.Crab;
            Cost = 5;
            Glory = 0;
            Military = 7;
            Political = 2;
            Text = "While you have not lost a conflict this phase, cancel the effects of the first action ability your opponent triggers from a card during each conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_37.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
