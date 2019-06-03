using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class YogoOutcastCard : CharacterCard
    {
        public YogoOutcastCard()
        {
            Name = "Yogo Outcast";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "This character gets +1[conflict-military] and +1[conflict-political] while you are less honorable than an opponent.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_100.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
