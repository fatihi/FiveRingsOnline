using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AgashaSwordsmithCard : CharacterCard
    {
        public AgashaSwordsmithCard()
        {
            Name = "Agasha Swordsmith";
            Clan = Clan.Dragon;
            Cost = 2;
            Glory = 1;
            Military = 1;
            Political = 2;
            Text = "<b>Action:</b> Search the top 5 cards of your conflict deck for an attachment, reveal it, and add it to your hand. Shuffle.";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Fire
            };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_56.jpg");
            AllowedClans = new[]
            {
                Clan.Dragon
            };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
