using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeppunGuardsmanCard : CharacterCard
    {
        public SeppunGuardsmanCard()
        {
            Name = "Seppun Guardsman";
            Clan = Clan.Neutral;
            Cost = 1;
            Glory = 1;
            Military = 2;
            Political = null;
            Text = "This character cannot participate in conflicts as an attacker against a player that controls the Imperial Favor.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Imperial
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_123.jpg");
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
