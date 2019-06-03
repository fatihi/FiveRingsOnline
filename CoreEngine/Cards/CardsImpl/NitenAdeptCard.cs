using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class NitenAdeptCard : CharacterCard
    {
        public NitenAdeptCard()
        {
            Name = "Niten Adept";
            Clan = Clan.Dragon;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 1;
            Text = "<b>Action:</b> While this character is participating in a conflict, bow a <i>(friendly)</i> attachment on it. Choose a participating character without attachments – bow that character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_58.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
