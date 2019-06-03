using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class ShosuroMiyakoCard : CharacterCard
    {
        public ShosuroMiyakoCard()
        {
            Name = "Shosuro Miyako";
            Clan = Clan.Scorpion;
            Cost = 3;
            Glory = 1;
            Military = 3;
            Political = 2;
            Text = "<b>Reaction:</b> After you play a character from your hand, your opponent must select one – discard 1 card at random from his or her hand or choose and dishonor a character he or she controls.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Shinobi
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_104.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
