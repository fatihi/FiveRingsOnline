using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShinjoOutriderCard : CharacterCard
    {
        public ShinjoOutriderCard()
        {
            Name = "Shinjo Outrider";
            Clan = Clan.Unicorn;
            Cost = 2;
            Glory = 2;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> During a conflict – move this character to the conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_114.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
