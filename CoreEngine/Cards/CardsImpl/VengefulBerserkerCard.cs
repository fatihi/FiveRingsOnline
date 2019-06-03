using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class VengefulBerserkerCard : CharacterCard
    {
        public VengefulBerserkerCard()
        {
            Name = "Vengeful Berserker";
            Clan = Clan.Crab;
            Cost = 3;
            Glory = 0;
            Military = 3;
            Political = null;
            Text = "<b>Reaction:</b> After another character you control leaves play during a conflict – double this character's [conflict-military] skill until the end of the conflict.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Berserker
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_33.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
