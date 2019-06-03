using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShosuroActressCard : CharacterCard
    {
        public ShosuroActressCard()
        {
            Name = "Shosuro Actress";
            Clan = Clan.Scorpion;
            Cost = 3;
            Glory = 1;
            Military = 1;
            Political = 3;
            Text = "<b>Action:</b> During a conflict, sacrifice this character. Choose a non-<em>Shinobi</em> character with printed cost 3 or lower in an opponent's discard pile – put that character into play in the conflict under your control.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Shinobi
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_103.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
