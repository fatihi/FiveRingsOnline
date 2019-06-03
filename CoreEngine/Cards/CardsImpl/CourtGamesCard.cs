using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CourtGamesCard : EventCard
    {
        public CourtGamesCard()
        {
            Name = "Court Games";
            Clan = Clan.Neutral;
            Cost = 0;
            Text = "<b>Action:</b> During a [conflict-political] conflict, select one – choose and honor a participating character you control, or your opponent chooses and dishonors a participating character he or she controls. (Max 1 per conflict.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_206.jpg");
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
