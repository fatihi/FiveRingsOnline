using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KitsuSpiritcallerCard : CharacterCard
    {
        public KitsuSpiritcallerCard()
        {
            Name = "Kitsu Spiritcaller";
            Clan = Clan.Lion;
            Cost = 3;
            Glory = 2;
            Military = 1;
            Political = 3;
            Text = "<b>Action:</b> During a conflict, bow this character. Choose a character in one of your discard piles – put that character into play in the conflict. If that character is still in play at the end of the conflict, return it to the bottom of its deck.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Water
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_74.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
