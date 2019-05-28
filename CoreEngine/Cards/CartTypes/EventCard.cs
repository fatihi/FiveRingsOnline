namespace CoreEngine.Cards.CartTypes
{
    public abstract class EventCard : Card
    {
        public int? Cost { get; set; }
        public Clan Clan { get; set; }

        public int? InfluenceCost { get; set; }

        public override CardType Type => CardType.Event;
    }
}