using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CityOfTheOpenHandCard : StrongholdCard
    {
        public CityOfTheOpenHandCard()
        {
            Name = "City of the Open Hand";
            Clan = Clan.Scorpion;
            Fate = 7;
            Honor = 10;
            InfluencePool = 10;
            StrengthBonus = 1;
            Text = "<b>Action:</b> If you are less honorable than an opponent, bow this stronghold and select one – either that opponent loses 1 honor, or you gain 1 honor.\n<i>Errata from RRG v9</i>";
            Traits = new[] { Trait.City };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("https://images-cdn.fantasyflightgames.com/filer_public/ee/eb/eeeb8cbd-ca17-475b-bc69-e31520d8e952/l5c01_city-of-the-open-hand.png");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
