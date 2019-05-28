using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AdeptOfShadowsCard : CharacterCard
    {
        public AdeptOfShadowsCard()
        {
            Name = "Adept of Shadows";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 0;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> Lose 1 honor – return this character to your hand.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Shinobi
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_180.jpg");
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
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
