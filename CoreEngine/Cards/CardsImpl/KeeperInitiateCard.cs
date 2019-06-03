using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KeeperInitiateCard : CharacterCard
    {
        public KeeperInitiateCard()
        {
            Name = "Keeper Initiate";
            Clan = Clan.Neutral;
            Cost = 2;
            Glory = 2;
            Military = 1;
            Political = 1;
            Text = "<em>Keeper</em> role only.\n<b>Reaction:</b> After you claim a ring that matches the element of your role – put this character into play from your dynasty discard pile or provinces. Then, put 1 fate on this character.";
            Traits = new[] { Trait.Monk };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_124.jpg");
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
