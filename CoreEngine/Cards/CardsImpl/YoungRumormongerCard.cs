using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class YoungRumormongerCard : CharacterCard
    {
        public YoungRumormongerCard()
        {
            Name = "Young Rumormonger";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 1;
            Military = 2;
            Political = 2;
            Text = "<b>Interrupt:</b> When a character would be honored or dishonored, choose another character controlled by the same player – that character receives the honor or dishonor instead.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_101.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = true;
            Side = Side.Dynasty;
        }
    }
}
