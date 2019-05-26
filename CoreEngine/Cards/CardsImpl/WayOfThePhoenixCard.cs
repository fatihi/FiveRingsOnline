using System.Collections.Generic;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class WayOfThePhoenixCard : EventCard
    {
        public WayOfThePhoenixCard()
        {
            Name = "Way of the Phoenix";
            Cost = 0;
            Actions = new List<Action>
            {
                new Action()
            };
        }
    }
}
