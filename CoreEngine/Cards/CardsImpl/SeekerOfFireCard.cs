using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfFireCard : RoleCard
    {
        public SeekerOfFireCard()
        {
            Name = "Seeker of Fire";
            RoleType = RoleType.Seeker;
            Element = Cards.Element.Fire;
            Clan = Clan.Neutral;
            Text = "You may replace 1 province of any element with an additional [element-fire] province while deckbuilding.\n<b>Reaction:</b> After a [element-fire] province you control is revealed – gain 1 fate.";
            Traits = new[]
            {
                Trait.Seeker,
                Trait.Fire
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_216B.jpg");
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
