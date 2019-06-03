using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FallenInBattleCard : EventCard
    {
        public FallenInBattleCard()
        {
            Name = "Fallen in Battle";
            Clan = Clan.Neutral;
            Cost = 1;
            Text = "<b>Reaction:</b> After you win a [conflict-military] conflict by 5 or more skill, choose a participating character – discard that character. (Max 1 per conflict.)";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_211.jpg");
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
