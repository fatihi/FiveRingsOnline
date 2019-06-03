using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShiroNishiyamaCard : StrongholdCard
    {
        public ShiroNishiyamaCard()
        {
            Name = "Shiro Nishiyama";
            Clan = Clan.Crab;
            Fate = 7;
            Honor = 10;
            InfluencePool = 10;
            StrengthBonus = 3;
            Text = "<b>Action:</b> During a conflict, bow this stronghold – each defending character you control gets +1[conflict-military] and +1[conflict-political] until the end of the conflict.";
            Traits = new[] { Trait.Castle };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_1.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
