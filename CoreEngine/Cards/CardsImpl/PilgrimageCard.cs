using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class PilgrimageCard : ProvinceCard
    {
        public PilgrimageCard()
        {
            Name = "Pilgrimage";
            Clan = Clan.Neutral;
            Element = Element.Void;
            Strength = 5;
            Text = "During conflicts at this province, cancel all ring effects. <i>(If this province breaks, resolve ring effects as normal.)</i>";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_22.jpg");
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
