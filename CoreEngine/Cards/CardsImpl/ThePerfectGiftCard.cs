using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ThePerfectGiftCard : EventCard
    {
        public ThePerfectGiftCard()
        {
            Name = "The Perfect Gift";
            Clan = Clan.Crane;
            Cost = 0;
            Text = "<b>Action:</b> Reveal the top 4 cards of each player's conflict deck. Choose 1 revealed card owned by each player and add it to its owner's hand. Shuffle.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_144.jpg");
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
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
