using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AsahinaArtisanCard : CharacterCard
    {
        public AsahinaArtisanCard()
        {
            Name = "Asahina Artisan";
            Clan = Clan.Crane;
            Cost = 1;
            Glory = 2;
            Military = 0;
            Political = 0;
            Text = "<b>Action:</b> During a conflict, bow this character. Choose another [clan-crane] character – that character gets +3[conflict-political] until the end of the conflict.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_40.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
