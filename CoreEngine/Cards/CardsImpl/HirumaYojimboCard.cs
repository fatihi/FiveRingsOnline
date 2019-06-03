using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HirumaYojimboCard : CharacterCard
    {
        public HirumaYojimboCard()
        {
            Name = "Hiruma Yōjimbō";
            Clan = Clan.Crab;
            Cost = 2;
            Glory = 2;
            Military = 4;
            Political = 3;
            Text = "This character cannot be declared as an attacker.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Yojimbo
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_28.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
