using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HonoredGeneralCard : CharacterCard
    {
        public HonoredGeneralCard()
        {
            Name = "Honored General";
            Clan = Clan.Lion;
            Cost = 4;
            Glory = 2;
            Military = 3;
            Political = 1;
            Text = "During a conflict in which this character is participating, each other participating [clan-lion] character you control gets +1[conflict-military].\n<b>Reaction:</b> After this character enters play – honor it.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Commander
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_77.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
