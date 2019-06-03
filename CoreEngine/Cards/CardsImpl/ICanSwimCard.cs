using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ICanSwimCard : EventCard
    {
        public ICanSwimCard()
        {
            Name = "I Can Swim";
            Clan = Clan.Scorpion;
            Cost = 2;
            Text = "<b>Action:</b> During a conflict, if the bid on your honor dial is higher than an opponent's, choose a participating dishonored character controlled by that opponent – discard that character.";
            Traits = new[] { Trait.Philosophy };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_187.jpg");
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
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
