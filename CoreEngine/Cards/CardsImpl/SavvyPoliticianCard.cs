using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SavvyPoliticianCard : CharacterCard
    {
        public SavvyPoliticianCard()
        {
            Name = "Savvy Politician";
            Clan = Clan.Crane;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 2;
            Text = "<b>Reaction:</b> After this character is honored, choose a character – honor that character.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_45.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
