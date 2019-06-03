using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IuchiWayfinderCard : CharacterCard
    {
        public IuchiWayfinderCard()
        {
            Name = "Iuchi Wayfinder";
            Clan = Clan.Unicorn;
            Cost = 1;
            Glory = 0;
            Military = 1;
            Political = 1;
            Text = "<b>Reaction:</b> After this character enters play – look at a facedown province.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Water,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_190.jpg");
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
