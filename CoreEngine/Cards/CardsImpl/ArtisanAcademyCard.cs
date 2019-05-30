using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ArtisanAcademyCard : HoldingCard
    {
        public ArtisanAcademyCard()
        {
            Name = "Artisan Academy";
            Clan = Clan.Crane;
            StrengthBonus = 1;
            Text = "<b>Action:</b> During the conflict phase – reveal the top card of your conflict deck. Until the end of the phase, you may play that card as if it were in your hand.";
            Traits = new[] { Trait.Academy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_53.jpg");
            AllowedClans = new[]
            {
                Clan.Crane
            };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
