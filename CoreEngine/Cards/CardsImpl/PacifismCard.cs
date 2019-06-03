using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class PacifismCard : AttachmentCard
    {
        public PacifismCard()
        {
            Name = "Pacifism";
            Clan = Clan.Phoenix;
            Cost = 2;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "This attachment cannot be played during a conflict.\nAttached character cannot participate in [conflict-military] conflicts.";
            Traits = new[] { Trait.Condition };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_174.jpg");
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
