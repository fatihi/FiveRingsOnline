using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DuelistTrainingCard : AttachmentCard
    {
        public DuelistTrainingCard()
        {
            Name = "Duelist Training";
            Clan = Clan.Crane;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "Attached character gains: \"<b>Action:</b> While this character is participating in a conflict, choose a participating character controlled by your opponent – challenge that character to a [conflict-military] duel. Instead of giving honor for this duel's bid, a player may choose and discard the required number of cards from hand. Bow the loser of the duel.\"";
            Traits = new[] { Trait.Technique };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_142.jpg");
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
