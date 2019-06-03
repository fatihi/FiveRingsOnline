using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SteadfastSamuraiCard : CharacterCard
    {
        public SteadfastSamuraiCard()
        {
            Name = "Steadfast Samurai";
            Clan = Clan.Lion;
            Cost = 1;
            Glory = 1;
            Military = 1;
            Political = 1;
            Text = "<b>Forced Reaction:</b> After the fate phase begins, if you have at least 5 more honor than an opponent – this character cannot be discarded or lose fate this phase.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_70.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
