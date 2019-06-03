using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ImperialStorehouseCard : HoldingCard
    {
        public ImperialStorehouseCard()
        {
            Name = "Imperial Storehouse";
            Clan = Clan.Neutral;
            StrengthBonus = 1;
            Text = "<b>Action:</b> Sacrifice this holding – draw 1 card.";
            Traits = new[] { Trait.Imperial };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_129.jpg");
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
