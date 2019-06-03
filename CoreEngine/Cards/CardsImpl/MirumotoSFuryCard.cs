using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MirumotoSFuryCard : EventCard
    {
        public MirumotoSFuryCard()
        {
            Name = "Mirumoto's Fury";
            Clan = Clan.Dragon;
            Cost = 1;
            Text = "<b>Action:</b> During a conflict, choose an attacking character with glory X or lower – bow that character. X is equal to the number of unrevealed provinces you control.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_159.jpg");
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
