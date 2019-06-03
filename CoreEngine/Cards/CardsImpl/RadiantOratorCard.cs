using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class RadiantOratorCard : CharacterCard
    {
        public RadiantOratorCard()
        {
            Name = "Radiant Orator";
            Clan = Clan.Phoenix;
            Cost = 3;
            Glory = 2;
            Military = 1;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, if you count more current glory than your opponent among ready participating characters, choose an enemy character – move that character home.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_87.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
