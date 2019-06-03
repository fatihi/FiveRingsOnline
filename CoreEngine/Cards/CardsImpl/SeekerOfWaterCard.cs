using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfWaterCard : RoleCard
    {
        public SeekerOfWaterCard()
        {
            Name = "Seeker of Water";
            RoleType = RoleType.Seeker;
            Element = Cards.Element.Water;
            Clan = Clan.Neutral;
            Text = "You may replace 1 province of any element with an additional [element-water] province while deckbuilding.\n<b>Reaction:</b> After a [element-water] province you control is revealed – gain 1 fate.";
            Traits = new[]
            {
                Trait.Seeker,
                Trait.Water
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_217B.jpg");
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
            Side = Side.Role;
        }
    }
}
