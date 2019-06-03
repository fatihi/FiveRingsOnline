using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ForgedEdictCard : EventCard
    {
        public ForgedEdictCard()
        {
            Name = "Forged Edict";
            Clan = Clan.Scorpion;
            Cost = 0;
            Text = "<b>Interrupt:</b> When the effects of an event would initiate, dishonor a <i>(friendly)</i> <em>Courtier</em> character – cancel those effects.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_184.jpg");
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
            IsRestricted = true;
            Side = Side.Conflict;
        }
    }
}
