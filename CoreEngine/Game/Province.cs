using System;
using CoreEngine.Cards;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Game
{
    public class Province
    {
        public Guid Id { get; set; }
        public Card ContainedCard { get; set; }
        public ProvinceCard ProvinceCard { get; set; }

        public bool IsStrongholdProvince => ContainedCard.Type == CardType.Stronghold;
    }
}