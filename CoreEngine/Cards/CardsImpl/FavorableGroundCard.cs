using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FavorableGroundCard : HoldingCard
    {
        public FavorableGroundCard()
        {
            Name = "Favorable Ground";
            Clan = Clan.Neutral;
            StrengthBonus = 1;
            Text = "<b>Action:</b> During a conflict, sacrifice this holding. Choose a character you control – move that character to the conflict or home from the conflict.";
            Traits = new[] { Trait.Battlefield };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_128.jpg");
            AllowedClans = new[]
            {
                Clan.Crab,
                Clan.Crane,
                Clan.Dragon,
                Clan.Lion,
                Clan.Phoenix,
                Clan.Scorpion,
                Clan.Unicorn
            };
            DeckLimit = 3;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
