using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SolemnScholarCard : CharacterCard
    {
        public SolemnScholarCard()
        {
            Name = "Solemn Scholar";
            Clan = Clan.Phoenix;
            Cost = 1;
            Glory = 1;
            Military = 1;
            Political = 1;
            Text = "<b>Action:</b> During a conflict, if the [element-earth] ring is in your claimed ring pool, choose an attacking character – bow that character.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Earth,
                Trait.Scholar
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_83.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
