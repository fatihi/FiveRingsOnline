using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AsakoDiplomatCard : CharacterCard
    {
        public AsakoDiplomatCard()
        {
            Name = "Asako Diplomat";
            Clan = Clan.Phoenix;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 2;
            Text = "<b>Reaction:</b> After this character wins a conflict, choose a character – honor or dishonor that character.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_85.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
