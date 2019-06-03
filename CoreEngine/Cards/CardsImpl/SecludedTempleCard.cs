using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SecludedTempleCard : HoldingCard
    {
        public SecludedTempleCard()
        {
            Name = "Secluded Temple";
            Clan = Clan.Dragon;
            StrengthBonus = 1;
            Text = "<b>Reaction:</b> After the conflict phase begins, each opponent who controls more characters than you must choose a character he or she controls with 1 or more fate on it – remove 1 fate from each chosen character.";
            Traits = new[] { Trait.Shrine };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_66.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
