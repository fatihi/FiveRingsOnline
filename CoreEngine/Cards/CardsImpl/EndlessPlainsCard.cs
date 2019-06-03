using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class EndlessPlainsCard : ProvinceCard
    {
        public EndlessPlainsCard()
        {
            Name = "Endless Plains";
            Clan = Clan.Unicorn;
            Element = Element.Water;
            Strength = 2;
            Text = "<b>Reaction:</b> After an attack is declared here, break this province. Your opponent chooses an attacking character – discard that character.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_14.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
