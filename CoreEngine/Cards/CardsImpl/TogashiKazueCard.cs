using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class TogashiKazueCard : CharacterCard
    {
        public TogashiKazueCard()
        {
            Name = "Togashi Kazue";
            Clan = Clan.Dragon;
            Cost = 3;
            Glory = 1;
            Military = 3;
            Political = 3;
            Text = "You may play this character as an attachment with the text: \"<b>Action:</b> During a conflict in which attached character is participating, choose another participating character – move 1 fate from that character to the attached character.\"";
            Traits = new[]
            {
                Trait.Monk,
                Trait.Tattooed
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_150.jpg");
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
