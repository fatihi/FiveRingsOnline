using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShibaTsukuneCard : CharacterCard
    {
        public ShibaTsukuneCard()
        {
            Name = "Shiba Tsukune";
            Clan = Clan.Phoenix;
            Cost = 5;
            Glory = 4;
            Military = 4;
            Political = 4;
            Text = "<b>Interrupt:</b> When the conflict phase ends – resolve the ring effects of up to 2 unclaimed rings as if you were the attacking player.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_93.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
