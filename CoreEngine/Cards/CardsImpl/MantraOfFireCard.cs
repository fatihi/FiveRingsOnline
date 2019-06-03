using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MantraOfFireCard : EventCard
    {
        public MantraOfFireCard()
        {
            Name = "Mantra of Fire";
            Clan = Clan.Dragon;
            Cost = 0;
            Text = "<b>Reaction:</b> After an opponent declares a [element-fire] conflict, choose a <em>Monk</em> character or a character with a <em>Monk</em> attachment – place 1 fate on that character and draw 1 card.";
            Traits = new[]
            {
                Trait.Kiho,
                Trait.Fire
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_156.jpg");
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
