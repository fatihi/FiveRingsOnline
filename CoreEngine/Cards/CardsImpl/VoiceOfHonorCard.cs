using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class VoiceOfHonorCard : EventCard
    {
        public VoiceOfHonorCard()
        {
            Name = "Voice of Honor";
            Clan = Clan.Crane;
            Cost = 0;
            Text = "<b>Interrupt:</b> When the effects of an event would initiate, if you control more honored characters than an opponent – cancel those effects.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_145.jpg");
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
