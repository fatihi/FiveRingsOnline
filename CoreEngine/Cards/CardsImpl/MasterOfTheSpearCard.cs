using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MasterOfTheSpearCard : CharacterCard
    {
        public MasterOfTheSpearCard()
        {
            Name = "Master of the Spear";
            Clan = Clan.Lion;
            Cost = 3;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> While this character is attacking, your opponent must choose a participating character he or she controls – move that character home.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_161.jpg");
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
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
