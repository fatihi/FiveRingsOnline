using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BayushiManipulatorCard : CharacterCard
    {
        public BayushiManipulatorCard()
        {
            Name = "Bayushi Manipulator";
            Clan = Clan.Scorpion;
            Cost = 1;
            Glory = 1;
            Military = 1;
            Political = 1;
            Text = "<b>Reaction:</b> After honor dials are revealed – increase the value of your bid by 1.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_96.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
