using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TogashiInitiateCard : CharacterCard
    {
        public TogashiInitiateCard()
        {
            Name = "Togashi Initiate";
            Clan = Clan.Dragon;
            Cost = 1;
            Glory = 2;
            Military = 1;
            Political = 1;
            Text = "<b>Action:</b> While this character is attacking, spend 1 fate to an unclaimed ring – honor this character.";
            Traits = new[]
            {
                Trait.Monk,
                Trait.Tattooed
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_55.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
