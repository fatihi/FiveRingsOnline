using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KaiuShuichiCard : CharacterCard
    {
        public KaiuShuichiCard()
        {
            Name = "Kaiu Shuichi";
            Clan = Clan.Crab;
            Cost = 4;
            Glory = 2;
            Military = 3;
            Political = 3;
            Text = "Covert. <i>(When this character attacks, choose one character without covert. That character cannot be declared as a defender.)</i>\n<b>Action:</b> During a conflict in which this character is participating, if there is a holding in play – gain 1 fate.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Engineer
            };
            Keywords = new[] { Keyword.Covert };
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_36.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
