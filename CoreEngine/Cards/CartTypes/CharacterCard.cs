namespace CoreEngine.Cards.CartTypes
{
    public class CharacterCard : Card
    {
        public int? Cost { get; set; }
        public int? Military { get; set; }
        public int? Political { get; set; }
        public Clan Clan { get; set; }
        public int Glory { get; set; }

        public override CardType Type => CardType.Character;
    }
}
