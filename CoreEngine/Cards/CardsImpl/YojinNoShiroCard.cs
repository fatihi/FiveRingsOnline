using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class YojinNoShiroCard : StrongholdCard
    {
        public YojinNoShiroCard()
        {
            Name = "Yōjin no Shiro";
            Clan = Clan.Lion;
            Fate = 7;
            Honor = 12;
            InfluencePool = 10;
            StrengthBonus = 2;
            Text = "<b>Action:</b> During a conflict, bow this stronghold – each attacking character you control gets +1[conflict-military] until the end of the conflict.";
            Traits = new[] { Trait.Castle };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_4.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
