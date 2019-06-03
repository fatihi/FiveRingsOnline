using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MotoHordeCard : CharacterCard
    {
        public MotoHordeCard()
        {
            Name = "Moto Horde";
            Clan = Clan.Unicorn;
            Cost = 4;
            Glory = 1;
            Military = 6;
            Political = null;
            Text = "No attachments except <em>Weapon</em>.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Army,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_119.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
