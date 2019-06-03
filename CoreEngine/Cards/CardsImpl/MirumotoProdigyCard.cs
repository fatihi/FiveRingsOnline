using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MirumotoProdigyCard : CharacterCard
    {
        public MirumotoProdigyCard()
        {
            Name = "Mirumoto Prodigy";
            Clan = Clan.Dragon;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "While this character is attacking alone, your opponent cannot declare more than one defender.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Duelist
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_57.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
