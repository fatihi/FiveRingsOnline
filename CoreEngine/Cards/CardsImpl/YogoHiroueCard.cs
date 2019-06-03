using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class YogoHiroueCard : CharacterCard
    {
        public YogoHiroueCard()
        {
            Name = "Yogo Hiroue";
            Clan = Clan.Scorpion;
            Cost = 4;
            Glory = 2;
            Military = 0;
            Political = 4;
            Text = "<b>Action:</b> While this character is participating in a conflict, choose a non-participating character – move that character to this conflict. Then, if you win the conflict, you may dishonor that character.";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_106.jpg");
            AllowedClans = new[] { Clan.Scorpion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
