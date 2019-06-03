using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ForgottenLibraryCard : HoldingCard
    {
        public ForgottenLibraryCard()
        {
            Name = "Forgotten Library";
            Clan = Clan.Phoenix;
            StrengthBonus = 0;
            Text = "<b>Reaction:</b> After the draw phase begins – draw 1 card.";
            Traits = new[]
            {
                Trait.Library,
                Trait.Shrine
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_94.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
