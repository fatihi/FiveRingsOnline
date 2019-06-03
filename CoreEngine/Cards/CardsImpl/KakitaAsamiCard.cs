using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KakitaAsamiCard : CharacterCard
    {
        public KakitaAsamiCard()
        {
            Name = "Kakita Asami";
            Clan = Clan.Crane;
            Cost = 3;
            Glory = 2;
            Military = 1;
            Political = 3;
            Text = "<b>Action:</b> While this character is participating in a [conflict-political] conflict, if you count more current [conflict-political] skill in the conflict than your opponent – take 1 honor from that opponent.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_48.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
