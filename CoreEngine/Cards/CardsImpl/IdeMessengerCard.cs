using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IdeMessengerCard : CharacterCard
    {
        public IdeMessengerCard()
        {
            Name = "Ide Messenger";
            Clan = Clan.Unicorn;
            Cost = 2;
            Glory = 0;
            Military = 1;
            Political = 2;
            Text = "<b>Action:</b> During a conflict, spend 1 fate. Choose a character you control – move that character to the conflict.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_191.jpg");
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
