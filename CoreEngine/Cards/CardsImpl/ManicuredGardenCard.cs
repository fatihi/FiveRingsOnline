using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ManicuredGardenCard : ProvinceCard
    {
        public ManicuredGardenCard()
        {
            Name = "Manicured Garden";
            Clan = Clan.Neutral;
            Element = Element.Air;
            Strength = 4;
            Text = "<b>Action:</b> During a conflict at this province – gain 1 fate.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_19.jpg");
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
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
