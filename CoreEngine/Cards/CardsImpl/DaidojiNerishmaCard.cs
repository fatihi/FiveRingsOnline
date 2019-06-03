using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class DaidojiNerishmaCard : CharacterCard
    {
        public DaidojiNerishmaCard()
        {
            Name = "Daidoji Nerishma";
            Clan = Clan.Crane;
            Cost = 2;
            Glory = 1;
            Military = 3;
            Political = 1;
            Text = "<b>Action:</b> Choose a facedown card in one of your provinces – turn that card faceup.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Scout
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_46.jpg");
            AllowedClans = new[] { Clan.Crane };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
