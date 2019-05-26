using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class SeekerOfVoidCard : RoleCard
    {
        public SeekerOfVoidCard()
        {
            Name = "Seeker of Void";
            RoleType = RoleType.Seeker;
            Element = CartTypes.Element.Void;
        }
    }
}
