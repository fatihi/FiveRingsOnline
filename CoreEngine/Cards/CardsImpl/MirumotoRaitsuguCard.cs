using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MirumotoRaitsuguCard : CharacterCard
    {
        public MirumotoRaitsuguCard()
        {
            Name = "Mirumoto Raitsugu";
            Clan = Clan.Dragon;
            Cost = 3;
            Glory = 1;
            Military = 3;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, choose a participating character controlled by your opponent – challenge that character to a [conflict-military] duel. If the loser of the duel has no fate on it, discard it. Otherwise remove 1 fate from it.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Duelist
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_62.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
