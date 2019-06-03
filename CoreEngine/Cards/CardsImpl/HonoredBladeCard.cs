using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class HonoredBladeCard : AttachmentCard
    {
        public HonoredBladeCard()
        {
            Name = "Honored Blade";
            Clan = Clan.Lion;
            Cost = 1;
            MilitaryBonus = 2;
            PoliticalBonus = 0;
            Text = "Restricted. <i>(No more than two restricted attachments per character.)</i>\n<b>Reaction:</b> After attached character wins a conflict – gain 1 honor.";
            Traits = new[] { Trait.Weapon };
            Keywords = new[] { Keyword.Restricted };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_163.jpg");
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
