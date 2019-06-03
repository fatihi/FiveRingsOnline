using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IdeTraderCard : CharacterCard
    {
        public IdeTraderCard()
        {
            Name = "Ide Trader";
            Clan = Clan.Unicorn;
            Cost = 3;
            Glory = 1;
            Military = 1;
            Political = 3;
            Text = "<b>Reaction:</b> After 1 or more characters move to a conflict in which this character is participating, select one – gain 1 fate or draw 1 card. (Limit once per conflict.)";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_116.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
