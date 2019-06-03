using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FearsomeMysticCard : CharacterCard
    {
        public FearsomeMysticCard()
        {
            Name = "Fearsome Mystic";
            Clan = Clan.Phoenix;
            Cost = 4;
            Glory = 1;
            Military = 2;
            Political = 4;
            Text = "This character gets +2 glory during [element-air] conflicts.\n<b>Action:</b> While this character is participating in a conflict – remove 1 fate from each participating character your opponent controls with lower glory than this character.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_91.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
