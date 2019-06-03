using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfKnowledgeCard : CharacterCard
    {
        public SeekerOfKnowledgeCard()
        {
            Name = "Seeker of Knowledge";
            Clan = Clan.Phoenix;
            Cost = 2;
            Glory = 1;
            Military = 0;
            Political = 2;
            Text = "While this character is attacking, the contested ring gains the [element-air] element. If this character wins the conflict as an attacker, you may choose which of its ring effects to resolve.";
            Traits = new[]
            {
                Trait.Courtier,
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_171.jpg");
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
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
