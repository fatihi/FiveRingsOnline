namespace CoreEngine.Cards.CartTypes
{
    public abstract class EventCard : Card
    {
        public int? Cost { get; set; }

        public override CardType Type => CardType.Event;
    }
}