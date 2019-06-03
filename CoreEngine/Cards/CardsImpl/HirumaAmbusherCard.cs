using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HirumaAmbusherCard : CharacterCard
    {
        public HirumaAmbusherCard()
        {
            Name = "Hiruma Ambusher";
            Clan = Clan.Crab;
            Cost = 2;
            Glory = 0;
            Military = 2;
            Political = 2;
            Text = "<b>Reaction:</b> After this character enters play as a defender, choose a character – that character's abilities cannot be triggered during this conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_130.jpg");
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
