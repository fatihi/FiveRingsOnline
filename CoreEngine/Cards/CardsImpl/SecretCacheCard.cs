using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SecretCacheCard : ProvinceCard
    {
        public SecretCacheCard()
        {
            Name = "Secret Cache";
            Clan = Clan.Scorpion;
            Element = Element.Air;
            Strength = 4;
            Text = "<b>Reaction:</b> After a conflict is declared against this province – search the top 5 cards of your conflict deck for a card and add it to your hand. Shuffle.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_13.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
