using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfEnlightenmentCard : CharacterCard
    {
        public SeekerOfEnlightenmentCard()
        {
            Name = "Seeker of Enlightenment";
            Clan = Clan.Dragon;
            Cost = 2;
            Glory = 0;
            Military = 1;
            Political = 1;
            Text = "This character gets +1[conflict-military] and +1[conflict-political] for each fate on each unclaimed ring.";
            Traits = new[]
            {
                Trait.Monk,
                Trait.Tattooed
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_59.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
