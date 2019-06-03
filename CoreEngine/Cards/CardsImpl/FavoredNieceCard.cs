using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FavoredNieceCard : CharacterCard
    {
        public FavoredNieceCard()
        {
            Name = "Favored Niece";
            Clan = Clan.Scorpion;
            Cost = 3;
            Glory = 2;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> Choose and discard 1 card from your hand – draw 1 card. (Limit twice per round.)";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_102.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
