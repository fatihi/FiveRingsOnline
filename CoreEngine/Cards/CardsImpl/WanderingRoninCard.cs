using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WanderingRoninCard : CharacterCard
    {
        public WanderingRoninCard()
        {
            Name = "Wandering Ronin";
            Clan = Clan.Neutral;
            Cost = 3;
            Glory = 0;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> During a conflict, remove 1 fate from this character – it gets +2[conflict-military] and +2[conflict-political] until the end of the conflict. (Limit twice per conflict.)";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Ronin
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_127.jpg");
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
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
