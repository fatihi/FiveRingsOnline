using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SinisterSoshiCard : CharacterCard
    {
        public SinisterSoshiCard()
        {
            Name = "Sinister Soshi";
            Clan = Clan.Scorpion;
            Cost = 1;
            Glory = 0;
            Military = null;
            Political = null;
            Text = "<b>Action:</b> During a conflict, choose a participating character – that character gets –2[conflict-military] and –2[conflict-political] until the end of the conflict.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Air
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_97.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
