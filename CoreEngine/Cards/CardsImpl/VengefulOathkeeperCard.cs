using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class VengefulOathkeeperCard : CharacterCard
    {
        public VengefulOathkeeperCard()
        {
            Name = "Vengeful Oathkeeper";
            Clan = Clan.Lion;
            Cost = 2;
            Glory = 0;
            Military = 2;
            Political = 1;
            Text = "<b>Reaction:</b> After you lose a [conflict-military] conflict – put this character into play from your hand.";
            Traits = new[] { Trait.Bushi };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_160.jpg");
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
