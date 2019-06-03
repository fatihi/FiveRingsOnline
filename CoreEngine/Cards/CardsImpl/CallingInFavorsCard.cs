using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CallingInFavorsCard : EventCard
    {
        public CallingInFavorsCard()
        {
            Name = "Calling in Favors";
            Clan = Clan.Scorpion;
            Cost = 1;
            Text = "<b>Action:</b> Dishonor a <i>(friendly)</i> character. Choose an opponent's attachment – take control of that attachment and attach it to that character, if able. Otherwise, discard the attachment.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_186.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
