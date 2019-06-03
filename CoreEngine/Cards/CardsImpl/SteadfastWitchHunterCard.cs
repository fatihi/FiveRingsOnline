using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SteadfastWitchHunterCard : CharacterCard
    {
        public SteadfastWitchHunterCard()
        {
            Name = "Steadfast Witch Hunter";
            Clan = Clan.Crab;
            Cost = 4;
            Glory = 0;
            Military = 4;
            Political = 2;
            Text = "<b>Action:</b> Sacrifice a <i>(friendly)</i> character. Choose a character – ready that character.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Earth
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_35.jpg");
            AllowedClans = new[] { Clan.Crab };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
