using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CityOfLiesCard : HoldingCard
    {
        public CityOfLiesCard()
        {
            Name = "City of Lies";
            Clan = Clan.Scorpion;
            StrengthBonus = 1;
            Text = "<b>Action:</b> Reduce the cost of the next event you play this phase by 1.";
            Traits = new[] { Trait.City };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_108.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
