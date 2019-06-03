using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class NaiveStudentCard : CharacterCard
    {
        public NaiveStudentCard()
        {
            Name = "Naive Student";
            Clan = Clan.Phoenix;
            Cost = 1;
            Glory = 2;
            Military = null;
            Political = 2;
            Text = "Sincerity. <i>(When this character leaves play, draw 1 card.)</i>";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Scholar
            };
            Keywords = new[] { Keyword.Sincerity };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_81.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
