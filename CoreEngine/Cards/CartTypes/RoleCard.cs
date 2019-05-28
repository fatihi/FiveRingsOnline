namespace CoreEngine.Cards.CartTypes
{
    public abstract class RoleCard : Card
    {
        public RoleType RoleType { get; set; }
        public Element? Element { get; set; }
        public Clan? Clan { get; set; }

        public override CardType Type => CardType.Role;
    }
}
