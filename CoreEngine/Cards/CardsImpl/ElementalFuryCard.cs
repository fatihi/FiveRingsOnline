using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ElementalFuryCard : ProvinceCard
    {
        public ElementalFuryCard()
        {
            Name = "Elemental Fury";
            Clan = Clan.Neutral;
            Element = Element.Water;
            Strength = 4;
            Text = "<b>Reaction:</b> After this province is revealed – switch the contested ring with an unclaimed ring. <i>(The conflict retains its type.)</i>";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_16.jpg");
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
