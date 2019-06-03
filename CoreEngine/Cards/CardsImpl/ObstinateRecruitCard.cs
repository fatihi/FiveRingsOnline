using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ObstinateRecruitCard : CharacterCard
    {
        public ObstinateRecruitCard()
        {
            Name = "Obstinate Recruit";
            Clan = Clan.Lion;
            Cost = 0;
            Glory = 0;
            Military = 2;
            Political = 0;
            Text = "If an opponent is more honorable than you, discard this character.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_67.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
