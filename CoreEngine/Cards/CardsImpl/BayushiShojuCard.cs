using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BayushiShojuCard : CharacterCard
    {
        public BayushiShojuCard()
        {
            Name = "Bayushi Shoju";
            Clan = Clan.Scorpion;
            Cost = 5;
            Glory = 2;
            Military = 3;
            Political = 7;
            Text = "<b>Action:</b> While this character is participating in a [conflict-political] conflict, choose a participating character controlled by your opponent – until the end of the conflict, that character gets –1[conflict-political] and is discarded if its [conflict-political] skill is 0. (Limit twice per round.)";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Courtier,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_107.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
