using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerInitiateCard : CharacterCard
    {
        public SeekerInitiateCard()
        {
            Name = "Seeker Initiate";
            Clan = Clan.Neutral;
            Cost = 2;
            Glory = 2;
            Military = 1;
            Political = 1;
            Text = "<em>Seeker</em> role only.\n<b>Reaction:</b> After you claim a ring that matches the element of your role – search the top 5 cards of your conflict deck for a card and add it to your hand. Shuffle.";
            Traits = new[] { Trait.Monk };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_126.jpg");
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
