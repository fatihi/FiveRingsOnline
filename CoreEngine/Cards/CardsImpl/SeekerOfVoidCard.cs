using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfVoidCard : RoleCard
    {
        public SeekerOfVoidCard()
        {
            Name = "Seeker of Void";
            RoleType = RoleType.Seeker;
            Element = Cards.Element.Void;
            Clan = Clan.Neutral;
            Text = "You may replace 1 province of any element with an additional [element-void] province while deckbuilding.\\n<b>Reaction:</b> After a [element-void] province you control is revealed – gain 1 fate.";
            Traits = new[]
            {
                Trait.Seeker,
                Trait.Void
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_218B.jpg");
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
