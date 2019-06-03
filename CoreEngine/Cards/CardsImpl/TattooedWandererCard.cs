using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TattooedWandererCard : CharacterCard
    {
        public TattooedWandererCard()
        {
            Name = "Tattooed Wanderer";
            Clan = Clan.Dragon;
            Cost = 1;
            Glory = 0;
            Military = 2;
            Political = 1;
            Text = "You may play this character as an attachment with the text: \"Attached character gains covert.\"";
            Traits = new[]
            {
                Trait.Monk,
                Trait.Tattooed
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_149.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
