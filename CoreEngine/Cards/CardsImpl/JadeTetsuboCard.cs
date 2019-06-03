using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class JadeTetsuboCard : AttachmentCard
    {
        public JadeTetsuboCard()
        {
            Name = "Jade Tetsubō";
            Clan = Clan.Crab;
            Cost = 2;
            MilitaryBonus = 3;
            PoliticalBonus = 0;
            Text = "Attach to a character you control. Restricted.\n<b>Action:</b> While attached character is participating in a conflict, bow this attachment. Choose a participating character with lower [conflict-military] skill than attached character – return all fate on that character to its owner's fate pool.";
            Traits = new[]
            {
                Trait.Jade,
                Trait.Weapon
            };
            Keywords = new[] { Keyword.Restricted };
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_134.jpg");
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
            InfluenceCost = 2;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
