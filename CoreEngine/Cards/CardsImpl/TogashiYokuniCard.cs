using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TogashiYokuniCard : CharacterCard
    {
        public TogashiYokuniCard()
        {
            Name = "Togashi Yokuni";
            Clan = Clan.Dragon;
            Cost = 5;
            Glory = 3;
            Military = 5;
            Political = 5;
            Text = "<b>Action:</b> Choose a triggered ability printed on another character – this character gains that ability until the end of the phase. (Max 1 per round.)";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Shugenja,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_65.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
