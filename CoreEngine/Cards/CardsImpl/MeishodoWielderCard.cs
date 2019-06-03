using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MeishodoWielderCard : CharacterCard
    {
        public MeishodoWielderCard()
        {
            Name = "Meishōdō Wielder";
            Clan = Clan.Unicorn;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "Reduce the cost to play this character by 1 while you are the first player.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Water
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_113.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
