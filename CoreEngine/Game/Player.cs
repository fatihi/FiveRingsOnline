using System;
using System.Collections.Generic;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Game
{
    public class Player
    {
        public Guid Id { get; set; }
        public StrongholdCard Stronghold { get; set; }
        public RoleCard Role { get; set; }
        public IEnumerable<ProvinceCard> Provinces { get; set; }
    }
}
