using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CautiousScoutCard : CharacterCard
    {
        public CautiousScoutCard()
        {
            Name = "Cautious Scout";
            Clan = Clan.Crane;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 0;
            Text = "While this character is attacking alone, treat the defending province as if its printed text box were blank (except for <em>Traits</em>).";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_43.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
