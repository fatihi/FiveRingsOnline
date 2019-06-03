using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class FavoredMountCard : AttachmentCard
    {
        public FavoredMountCard()
        {
            Name = "Favored Mount";
            Clan = Clan.Unicorn;
            Cost = 1;
            MilitaryBonus = 1;
            PoliticalBonus = 0;
            Text = "Attach to a character you control.\nAttached character gains <em>Cavalry</em>.\n<b>Action:</b> During a conflict, bow this attachment – move attached character to the conflict.";
            Traits = new[] { Trait.Creature };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_192.jpg");
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
            InfluenceCost = 1;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
