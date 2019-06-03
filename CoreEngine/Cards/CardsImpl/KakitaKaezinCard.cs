using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KakitaKaezinCard : CharacterCard
    {
        public KakitaKaezinCard()
        {
            Name = "Kakita Kaezin";
            Clan = Clan.Crane;
            Cost = 3;
            Glory = 2;
            Military = 3;
            Political = 2;
            Text = "<b>Action:</b> While this character is participating in a conflict, your opponent must choose a participating character he or she controls – challenge that character to a [conflict-military] duel. If this character wins, move each character not involved in the duel home. If it loses, send it home.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Duelist,
                Trait.Kenshinzen
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_49.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
