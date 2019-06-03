using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DojiHotaruCard : CharacterCard
    {
        public DojiHotaruCard()
        {
            Name = "Doji Hotaru";
            Clan = Clan.Crane;
            Cost = 5;
            Glory = 3;
            Military = 3;
            Political = 6;
            Text = "<b>Reaction:</b> After you claim a ring during a [conflict-political] conflict in which this character is participating – resolve that ring's effect.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_52.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
