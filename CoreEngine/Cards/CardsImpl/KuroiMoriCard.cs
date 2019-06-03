using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KuroiMoriCard : ProvinceCard
    {
        public KuroiMoriCard()
        {
            Name = "Kuroi Mori";
            Clan = Clan.Phoenix;
            Element = Element.Void;
            Strength = 4;
            Text = "<b>Action:</b> During a conflict at this province, select one – switch the contested ring with an unclaimed ring <i>(the conflict retains its type)</i>, or switch the conflict type <i>(the conflict retains its element)</i>.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_12.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
