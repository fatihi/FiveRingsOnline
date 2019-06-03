using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WatchCommanderCard : AttachmentCard
    {
        public WatchCommanderCard()
        {
            Name = "Watch Commander";
            Clan = Clan.Crab;
            Cost = 1;
            MilitaryBonus = 1;
            PoliticalBonus = 1;
            Text = "Attach to a character you control. Limit 1 per character.\n<b>Reaction:</b> After an opponent plays a card during a conflict in which attached character is participating – that player loses 1 honor. (Unlimited.)";
            Traits = new[] { Trait.Follower };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_133.jpg");
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
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
