using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DeathseekerCard : CharacterCard
    {
        public DeathseekerCard()
        {
            Name = "Deathseeker";
            Clan = Clan.Lion;
            Cost = 2;
            Glory = 0;
            Military = 2;
            Political = 1;
            Text = "<b>Reaction:</b> After this character loses a conflict as an attacker, sacrifice this character. Choose a character controlled by your opponent – if that character has no fate on it, discard it. Otherwise, remove 1 fate from that character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_72.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
