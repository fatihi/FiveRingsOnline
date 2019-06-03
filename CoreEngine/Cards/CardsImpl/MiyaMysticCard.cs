using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MiyaMysticCard : CharacterCard
    {
        public MiyaMysticCard()
        {
            Name = "Miya Mystic";
            Clan = Clan.Neutral;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 1;
            Text = "<b>Action:</b> During the conflict phase, sacrifice this character. Choose an attachment – discard that attachment.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Earth,
                Trait.Imperial
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_125.jpg");
            AllowedClans = new[]
            {
                Clan.Crab,
                Clan.Crane,
                Clan.Dragon,
                Clan.Lion,
                Clan.Phoenix,
                Clan.Scorpion,
                Clan.Unicorn
            };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
