using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GoodOmenCard : EventCard
    {
        public GoodOmenCard()
        {
            Name = "Good Omen";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "Play only if your honor bid is lower than an opponent's.\n<b>Action:</b> Choose a character with printed cost 3 or higher – place 1 fate on that character.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_208.jpg");
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
