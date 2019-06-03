using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class RallyToTheCauseCard : ProvinceCard
    {
        public RallyToTheCauseCard()
        {
            Name = "Rally to the Cause";
            Clan = Clan.Neutral;
            Element = Element.Water;
            Strength = 4;
            Text = "<b>Reaction:</b> After this province is revealed – switch the conflict type. <i>(The conflict retains its element.)</i>";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_23.jpg");
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
