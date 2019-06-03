using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class NitenMasterCard : CharacterCard
    {
        public NitenMasterCard()
        {
            Name = "Niten Master";
            Clan = Clan.Dragon;
            Cost = 4;
            Glory = 2;
            Military = 3;
            Political = 3;
            Text = "<b>Reaction:</b> After you attach a <em>Weapon</em> attachment to this character – ready this character. (Limit twice per round.)";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_64.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = true;
            Side = Side.Dynasty;
        }
    }
}
