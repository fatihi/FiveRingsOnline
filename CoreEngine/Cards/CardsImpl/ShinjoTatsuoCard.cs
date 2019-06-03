using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShinjoTatsuoCard : CharacterCard
    {
        public ShinjoTatsuoCard()
        {
            Name = "Shinjo Tatsuo";
            Clan = Clan.Unicorn;
            Cost = 4;
            Glory = 2;
            Military = 3;
            Political = 3;
            Text = "<b>Action:</b> During a conflict, choose this character and up to 1 other character you control – move those characters to the conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_120.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
