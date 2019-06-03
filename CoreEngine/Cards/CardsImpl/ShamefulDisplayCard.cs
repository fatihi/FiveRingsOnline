using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShamefulDisplayCard : ProvinceCard
    {
        public ShamefulDisplayCard()
        {
            Name = "Shameful Display";
            Clan = Clan.Neutral;
            Element = Element.Void;
            Strength = 3;
            Text = "<b>Action:</b> During a conflict at this province, choose 2 participating characters – honor one of those characters and dishonor the other.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_24.jpg");
            AllowedClans = new[]
            {
                Clan.Crab,
                Clan.Crane,
                Clan.Dragon,
                Clan.Lion,
                Clan.Phoenix,
                Clan.Scorpion,
                Clan.Unicorn
            };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
