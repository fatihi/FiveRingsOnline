using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DojiChallengerCard : CharacterCard
    {
        public DojiChallengerCard()
        {
            Name = "Doji Challenger";
            Clan = Clan.Crane;
            Cost = 3;
            Glory = 2;
            Military = 3;
            Political = 3;
            Text = "<b>Action:</b> While this character is attacking, choose a character controlled by your opponent – move that character to this conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Duelist
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_47.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
