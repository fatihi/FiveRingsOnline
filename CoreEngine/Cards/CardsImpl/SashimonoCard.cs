using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SashimonoCard : AttachmentCard
    {
        public SashimonoCard()
        {
            Name = "Sashimono";
            Clan = Clan.Lion;
            Cost = 2;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Text = "Attach to a <em>Bushi</em> character you control.\nAttached character does not bow as a result of conflict resolution during [conflict-military] conflicts.";
            Traits = new[]
            {
                Trait.Item,
                Trait.Banner
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_164.jpg");
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
