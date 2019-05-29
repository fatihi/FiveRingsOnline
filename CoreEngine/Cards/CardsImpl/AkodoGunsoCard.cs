using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AkodoGunsoCard : CharacterCard
    {
        public AkodoGunsoCard()
        {
            Name = "Akodo Gunsō";
            Clan = Clan.Lion;
            Cost = 2;
            Glory = 2;
            Military = 2;
            Political = 1;
            Text = "Pride. <i>(After this character wins a conflict, honor it. After this character loses a conflict, dishonor it.)</i>\\n<b>Reaction:</b> After this character enters play from a province – refill that province faceup.";
            Traits = new[] { Trait.Bushi };
            Keywords = new[] { Keyword.Pride };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_71.jpg");
            AllowedClans = new[]
            {
                Clan.Lion
            };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
