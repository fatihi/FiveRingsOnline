using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfTheDragonCard : AttachmentCard
    {
        public WayOfTheDragonCard()
        {
            Name = "Way of the Dragon";
            Clan = Clan.Dragon;
            Cost = 2;
            MilitaryBonus = 1;
            PoliticalBonus = 1;
            Text = "Attach to a character you control. Limit 1 per character.\nYou may trigger each of attached character's triggered abilities an additional time each round (or specified period).";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_154.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
