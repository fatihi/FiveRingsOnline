using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BorderRiderCard : CharacterCard
    {
        public BorderRiderCard()
        {
            Name = "Border Rider";
            Clan = Clan.Unicorn;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 1;
            Text = "<b>Action:</b> Ready this character.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_112.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
