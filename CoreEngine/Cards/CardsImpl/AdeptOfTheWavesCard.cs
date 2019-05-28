using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AdeptOfTheWavesCard : CharacterCard
    {
        public AdeptOfTheWavesCard()
        {
            Name = "Adept of the Waves";
            Clan = Clan.Phoenix;
            Cost = 2;
            Glory = 2;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> Choose a character – until the end of the phase, that character gains covert during [element-water] conflicts.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Water
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_84.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
