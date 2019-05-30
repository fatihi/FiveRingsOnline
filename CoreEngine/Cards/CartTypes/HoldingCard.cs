namespace CoreEngine.Cards.CartTypes
{
    public abstract class HoldingCard : Card
    {
        public int StrengthBonus { get; set; }
        public Clan Clan { get; set; }

        public override CardType Type => CardType.Holding;
    }
}