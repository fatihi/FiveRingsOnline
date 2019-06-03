using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AsceticVisionaryCard : CharacterCard
    {
        public AsceticVisionaryCard()
        {
            Name = "Ascetic Visionary";
            Clan = Clan.Dragon;
            Cost = 4;
            Glory = 1;
            Military = 3;
            Political = 4;
            Text = "No attachments except <em>Monk</em> or <em>Tattoo</em>.\n<b>Action:</b> While this character is attacking, spend 1 fate to an unclaimed ring. Choose a <em>Monk</em> character or a character with a <em>Monk</em> attachment – ready that character.";
            Traits = new[]
            {
                Trait.Monk,
                Trait.Tattooed
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_63.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
