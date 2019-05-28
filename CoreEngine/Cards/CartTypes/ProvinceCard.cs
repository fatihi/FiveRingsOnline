namespace CoreEngine.Cards.CartTypes
{
    public abstract class ProvinceCard : Card
    {
        public Element Element { get; set; }
        public int Strength { get; set; }

        public override CardType Type => CardType.Province;
    }
}
