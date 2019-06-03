using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SoshiIllusionistCard : CharacterCard
    {
        public SoshiIllusionistCard()
        {
            Name = "Soshi Illusionist";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 3;
            Text = "<b>Action:</b> Spend 1 fate, choose a character – discard a status token from that character.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_99.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
