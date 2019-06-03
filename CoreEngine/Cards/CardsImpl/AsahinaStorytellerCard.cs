using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AsahinaStorytellerCard : CharacterCard
    {
        public AsahinaStorytellerCard()
        {
            Name = "Asahina Storyteller";
            Clan = Clan.Crane;
            Cost = 4;
            Glory = 2;
            Military = 2;
            Political = 4;
            Text = "Sincerity. <i>(When this character leaves play, draw 1 card.)</i>\nEach honored [clan-crane] character you control gains sincerity.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new[] { Keyword.Sincerity };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_50.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
