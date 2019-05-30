using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AncestralLandsCard : ProvinceCard
    {
        public AncestralLandsCard()
        {
            Name = "Ancestral Lands";
            Clan = Clan.Neutral;
            Element = Element.Earth;
            Strength = 5;
            Text = "This province gets +5 strength during [conflict-political] conflicts.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_15.jpg");
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
