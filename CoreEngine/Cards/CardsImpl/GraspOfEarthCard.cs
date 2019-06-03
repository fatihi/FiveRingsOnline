using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class GraspOfEarthCard : AttachmentCard
    {
        public GraspOfEarthCard()
        {
            Name = "Grasp of Earth";
            Clan = Clan.Phoenix;
            Cost = 1;
            MilitaryBonus = 1;
            PoliticalBonus = 1;
            Text = "Attach to a <em>Shugenja</em> character you control.\n<b>Action:</b> During a conflict, bow this attachment – opponents' characters cannot move to this conflict or be played from hand until the end of the conflict.";
            Traits = new[]
            {
                Trait.Spell,
                Trait.Earth
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_173.jpg");
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
