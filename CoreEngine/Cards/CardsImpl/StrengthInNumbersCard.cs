using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class StrengthInNumbersCard : EventCard
    {
        public StrengthInNumbersCard()
        {
            Name = "Strength in Numbers";
            Clan = Clan.Lion;
            Cost = 1;
            Text = "<b>Action:</b> While you are the attacking player, choose a defending character with glory X or lower – move that character home. X is equal to the number of attacking characters.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_169.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
