using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SpiesAtCourtCard : EventCard
    {
        public SpiesAtCourtCard()
        {
            Name = "Spies at Court";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Reaction:</b> After you win a [conflict-political] conflict, dishonor a <i>(friendly)</i> participating character – discard 2 cards at random from your opponent's hand. (Max 1 per conflict.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_209.jpg");
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
            DeckLimit = 3;
            InfluenceCost = 0;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
