using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShibaYojimboCard : CharacterCard
    {
        public ShibaYojimboCard()
        {
            Name = "Shiba Yōjimbō";
            Clan = Clan.Phoenix;
            Cost = 3;
            Glory = 2;
            Military = 3;
            Political = 2;
            Text = "<b>Interrupt:</b> When the effects of a triggered ability that targets a <em>Shugenja</em> you control would initiate – cancel those effects.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Yojimbo
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_89.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
