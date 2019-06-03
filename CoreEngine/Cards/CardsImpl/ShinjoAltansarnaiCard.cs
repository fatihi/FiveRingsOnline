using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShinjoAltansarnaiCard : CharacterCard
    {
        public ShinjoAltansarnaiCard()
        {
            Name = "Shinjo Altansarnai";
            Clan = Clan.Unicorn;
            Cost = 5;
            Glory = 2;
            Military = 5;
            Political = 4;
            Text = "<b>Reaction:</b> After you break a province during a [conflict-military] conflict in which this character is participating, your opponent chooses a character he or she controls – discard that character.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Cavalry,
                Trait.Champion
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_121.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
