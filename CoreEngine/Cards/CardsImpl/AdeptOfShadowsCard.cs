using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AdeptOfShadowsCard : CharacterCard
    {
        public AdeptOfShadowsCard()
        {
            Name = "Adept of Shadows";
            Clan = Clan.Scorpion;
            Cost = 2;
            Glory = 0;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> Lose 1 honor – return this character to your hand.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Shinobi
            };
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
            InfluenceCost = 3;
            IsRestricted = false;
            Side = Side.Conflict;
        }
    }
}
