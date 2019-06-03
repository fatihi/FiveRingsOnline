using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HidaTomonatsuCard : CharacterCard
    {
        public HidaTomonatsuCard()
        {
            Name = "Hida Tomonatsu";
            Clan = Clan.Crab;
            Cost = 3;
            Glory = 2;
            Military = 3;
            Political = 2;
            Text = "<b>Reaction:</b> After this character wins a conflict as a defender, sacrifice it. Choose a non-unique attacking character – return that character to the top of its owner's deck.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_34.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
