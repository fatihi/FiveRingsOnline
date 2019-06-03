using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AkodoToturiCard : CharacterCard
    {
        public AkodoToturiCard()
        {
            Name = "Akodo Toturi";
            Clan = Clan.Lion;
            Cost = 5;
            Glory = 3;
            Military = 6;
            Political = 3;
            Text = "<b>Reaction:</b> After you claim a ring during a [conflict-military] conflict in which this character is participating – resolve that ring's effect.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_79.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
