using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DojiGiftGiverCard : CharacterCard
    {
        public DojiGiftGiverCard()
        {
            Name = "Doji Gift Giver";
            Clan = Clan.Crane;
            Cost = 2;
            Glory = 1;
            Military = 0;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, give your opponent 1 fate. That opponent must choose a ready participating character he or she controls – bow that character.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_44.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
