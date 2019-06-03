using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class NightRaidCard : ProvinceCard
    {
        public NightRaidCard()
        {
            Name = "Night Raid";
            Clan = Clan.Neutral;
            Element = Element.Fire;
            Strength = 4;
            Text = "<b>Reaction:</b> After this province is revealed – your opponent chooses and discards X cards from his or her hand. X is equal to the number of attacking characters.";
            Traits = new Trait[0];
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_21.jpg");
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
