using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class MeditationsOnTheTaoCard : ProvinceCard
    {
        public MeditationsOnTheTaoCard()
        {
            Name = "Meditations on the Tao";
            Clan = Clan.Neutral;
            Element = Element.Fire;
            Strength = 4;
            Text = "<b>Action:</b> During a conflict at this province, choose an attacking character – remove 1 fate from that character.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_20.jpg");
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
            DeckLimit = 1;
            IsRestricted = false;
            Side = Side.Province;
        }
    }
}
