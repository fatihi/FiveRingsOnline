using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class OtomoCourtierCard : CharacterCard
    {
        public OtomoCourtierCard()
        {
            Name = "Otomo Courtier";
            Clan = Clan.Neutral;
            Cost = 1;
            Glory = 1;
            Military = null;
            Political = 2;
            Text = "This character cannot participate in conflicts as an attacker against a player that controls the Imperial Favor.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Imperial
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_122.jpg");
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
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
