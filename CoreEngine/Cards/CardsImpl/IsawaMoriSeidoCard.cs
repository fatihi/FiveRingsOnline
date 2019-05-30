using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IsawaMoriSeidoCard : StrongholdCard
    {
        public IsawaMoriSeidoCard()
        {
            Name = "Isawa Mori Seidō";
            Clan = Clan.Phoenix;
            Fate = 7;
            Honor = 11;
            InfluencePool = 10;
            StrengthBonus = 2;
            Text = "<b>Action:</b> Bow this stronghold, choose a character – that character gets +2 glory until the end of the phase.";
            Traits = new[]
            {
                Trait.Shrine
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_79.jpg");
            AllowedClans = new[]
            {
                Clan.Phoenix
            };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
