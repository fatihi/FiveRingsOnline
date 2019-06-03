using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SpyglassCard : AttachmentCard
    {
        public SpyglassCard()
        {
            Name = "Spyglass";
            Clan = Clan.Unicorn;
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 1;
            Text = "<b>Reaction:</b> After attached character commits to a conflict or moves to a conflict – draw 1 card. (Limit twice per round.)";
            Traits = new[]
            {
                Trait.Item,
                Trait.Gaijin
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_193.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
