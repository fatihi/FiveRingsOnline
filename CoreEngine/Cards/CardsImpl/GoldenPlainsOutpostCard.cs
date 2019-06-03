using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GoldenPlainsOutpostCard : StrongholdCard
    {
        public GoldenPlainsOutpostCard()
        {
            Name = "Golden Plains Outpost";
            Clan = Clan.Unicorn;
            Fate = 7;
            Honor = 10;
            InfluencePool = 10;
            StrengthBonus = 0;
            Text = "<b>Action:</b> During a [conflict-military] conflict, bow this stronghold. Choose a <em>Cavalry</em> character you control – move it to that conflict.";
            Traits = new[] { Trait.Outpost };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_7.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
