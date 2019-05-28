using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AdmitDefeatCard : EventCard
    {
        public AdmitDefeatCard()
        {
            Name = "Admit Defeat";
            Clan = Clan.Crane;
            Cost = 1;
            Text = "<b>Action:</b> Choose a character that is defending alone – bow that character.";
            Traits = new Trait[0];
            IsUnique = false;
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
