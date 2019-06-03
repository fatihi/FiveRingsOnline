using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class RebuildCard : EventCard
    {
        public RebuildCard()
        {
            Name = "Rebuild";
            Clan = Clan.Crab;
            Cost = 0;
            Text = "<b>Action:</b> Shuffle a card in one of your unbroken provinces back into your dynasty deck. Choose a holding in your dynasty discard pile – put that holding into play in that province.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_136.jpg");
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
            IsRestricted = true;
            Side = Side.Conflict;
        }
    }
}
