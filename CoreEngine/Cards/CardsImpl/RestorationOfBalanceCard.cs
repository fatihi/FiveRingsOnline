using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class RestorationOfBalanceCard : ProvinceCard
    {
        public RestorationOfBalanceCard()
        {
            Name = "Restoration of Balance";
            Clan = Clan.Dragon;
            Element = Element.Fire;
            Strength = 3;
            Text = "<b>Interrupt:</b> When this province is broken – your opponent chooses and discards cards from his or her hand until that player has 4 or fewer cards in hand.\n<i>Errata from RRG v9</i>";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("https://images-cdn.fantasyflightgames.com/filer_public/bd/7a/bd7a25c3-b0ba-4eb8-b391-03792a795f5b/l5c01_restoration-of-balance.png");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
