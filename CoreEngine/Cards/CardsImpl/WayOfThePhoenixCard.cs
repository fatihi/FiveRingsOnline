using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfThePhoenixCard : EventCard
    {
        public WayOfThePhoenixCard()
        {
            Name = "Way of the Phoenix";
            Clan = Clan.Phoenix;
            Cost = 0;
            Text = "<b>Action:</b> Choose a ring and an opponent – that player cannot declare conflicts of that ring's element this phase. (Max 1 per phase.)";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_176.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
