using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShrewdYasukiCard : CharacterCard
    {
        public ShrewdYasukiCard()
        {
            Name = "Shrewd Yasuki";
            Clan = Clan.Crab;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, if there is a holding in play – look at the top 2 cards of your conflict deck. Add 1 of those cards to your hand and place the other on the bottom of your conflict deck.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_29.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
