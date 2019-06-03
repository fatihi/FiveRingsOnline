using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MeddlingMediatorCard : CharacterCard
    {
        public MeddlingMediatorCard()
        {
            Name = "Meddling Mediator";
            Clan = Clan.Phoenix;
            Cost = 2;
            Glory = 1;
            Military = 0;
            Political = 3;
            Text = "<b>Action:</b> If an opponent has declared 2 or more conflicts against you this phase, select one – take 1 fate or 1 honor from that opponent.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_86.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
