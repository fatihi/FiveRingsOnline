using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KeeperOfWaterCard : RoleCard
    {
        public KeeperOfWaterCard()
        {
            Name = "Keeper of Water";
            RoleType = RoleType.Keeper;
            Element = Cards.Element.Water;
            Clan = Clan.Neutral;
            Text = "Increase your deckbuilding influence value by 3.\n<b>Reaction:</b> After you win a [element-water] conflict as the defending player – gain 1 fate.";
            Traits = new[]
            {
                Trait.Keeper,
                Trait.Water
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_217A.jpg");
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
