using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MountainSAnvilCastleCard : StrongholdCard
    {
        public MountainSAnvilCastleCard()
        {
            Name = "Mountain's Anvil Castle";
            Clan = Clan.Dragon;
            Fate = 7;
            Honor = 11;
            InfluencePool = 10;
            StrengthBonus = 2;
            Text = "<b>Action:</b> During a conflict, bow this stronghold. Choose a participating character with 1 or more attachments on it – until the end of the conflict, that character gets +1[conflict-military] and +1[conflict-political] (+2[conflict-military] and +2[conflict-political] instead if it has 2 or more attachments on it).";
            Traits = new[] { Trait.Castle };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_79.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
