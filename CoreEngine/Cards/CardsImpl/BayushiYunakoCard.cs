using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BayushiYunakoCard : CharacterCard
    {
        public BayushiYunakoCard()
        {
            Name = "Bayushi Yunako";
            Clan = Clan.Scorpion;
            Cost = 4;
            Glory = 2;
            Military = 4;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, choose a character – switch that character's base [conflict-military] and [conflict-political] skill until the end of the conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Commander
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_105.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
