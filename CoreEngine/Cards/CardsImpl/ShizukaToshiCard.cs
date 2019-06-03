using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShizukaToshiCard : StrongholdCard
    {
        public ShizukaToshiCard()
        {
            Name = "Shizuka Toshi";
            Clan = Clan.Crane;
            Fate = 7;
            Honor = 11;
            InfluencePool = 10;
            StrengthBonus = 2;
            Text = "<b>Action:</b> During a [conflict-political] conflict, bow this stronghold. Choose a participating character with [conflict-political] skill 2 or lower – bow that character.";
            Traits = new[] { Trait.City };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_2.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
