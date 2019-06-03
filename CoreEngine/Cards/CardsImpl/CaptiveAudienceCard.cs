using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CaptiveAudienceCard : EventCard
    {
        public CaptiveAudienceCard()
        {
            Name = "Captive Audience";
            Clan = Clan.Unicorn;
            Cost = 0;
            Text = "<b>Action:</b> During a [conflict-political] conflict, lose 1 honor – change the conflict type to [conflict-military].";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_196.jpg");
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
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
