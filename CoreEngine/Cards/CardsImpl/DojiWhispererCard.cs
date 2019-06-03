using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DojiWhispererCard : CharacterCard
    {
        public DojiWhispererCard()
        {
            Name = "Doji Whisperer";
            Clan = Clan.Crane;
            Cost = 1;
            Glory = 1;
            Military = 0;
            Political = 3;
            Text = null;
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_41.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
