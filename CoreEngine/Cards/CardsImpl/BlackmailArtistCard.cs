using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class BlackmailArtistCard : CharacterCard
    {
        public BlackmailArtistCard()
        {
            Name = "Blackmail Artist";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 2;
            Text = "<b>Reaction:</b> After this character wins a [conflict-political] conflict – take 1 honor from your opponent.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_98.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
