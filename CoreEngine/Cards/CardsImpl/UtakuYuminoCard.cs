using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class UtakuYuminoCard : CharacterCard
    {
        public UtakuYuminoCard()
        {
            Name = "Utaku Yumino";
            Clan = Clan.Unicorn;
            Cost = 3;
            Glory = 3;
            Military = 2;
            Political = 2;
            Text = "<b>Action:</b> During a conflict, discard a card from your hand – this character gets +2[conflict-military] and +2[conflict-political] until the end of the conflict. (Limit once per conflict.)";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.BattleMaiden,
                Trait.Cavalry
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_118.jpg");
            AllowedClans = new[] { Clan.Unicorn };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
