using System;
using CoreEngine.Utils;

namespace CoreEngine.Cards
{
    public class CardInstantiator
    {
        public Card CreateCard(string cardId)
        {
            var cardName = StringUtils.GetCardNameFromCardId(cardId);
            var type = Type.GetType("CoreEngine.Cards.CardsImpl." + cardName);
            var card = (Card) Activator.CreateInstance(type);
            card.CardId = cardId;
            card.Id = Guid.NewGuid();
            return card;
        }
    }
}
