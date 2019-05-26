namespace CoreEngine.Cards.CartTypes
{
    public abstract class StrongholdCard : Card
    {
        public int Honor { get; set; }
        public int InfluencePool { get; set; }
        public int Fate { get; set; }
        public int StrengthBonus { get; set; }

        public new CardType Type => CardType.Stronghold;
    }
}
