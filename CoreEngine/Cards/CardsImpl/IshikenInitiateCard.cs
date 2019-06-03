using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IshikenInitiateCard : CharacterCard
    {
        public IshikenInitiateCard()
        {
            Name = "Ishiken Initiate";
            Clan = Clan.Phoenix;
            Cost = 2;
            Glory = 0;
            Military = 1;
            Political = 1;
            Text = "This character gets +1[conflict-military] and +1[conflict-political] for each claimed ring.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Void
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_170.jpg");
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
