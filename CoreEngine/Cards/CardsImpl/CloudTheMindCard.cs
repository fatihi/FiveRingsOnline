using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class CloudTheMindCard : AttachmentCard
    {
        public CloudTheMindCard()
        {
            Name = "Cloud the Mind";
            Clan = Clan.Neutral;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "Play only if you control a <em>Shugenja</em> character.\nTreat attached character as if its printed text box were blank (except for <em>Traits</em>).";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_202.jpg");
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
            DeckLimit = 3;
            InfluenceCost = 0;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
