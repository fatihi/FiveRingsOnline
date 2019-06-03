using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class IsawaAtsukoCard : CharacterCard
    {
        public IsawaAtsukoCard()
        {
            Name = "Isawa Atsuko";
            Clan = Clan.Phoenix;
            Cost = 4;
            Glory = 2;
            Military = 3;
            Political = 3;
            Text = "<b>Action:</b> During a [element-void] conflict – until the end of the conflict, each participating character you control gets +1[conflict-military] and +1[conflict-political] and each participating character your opponent controls gets –1[conflict-military] and –1[conflict-political].";
            Traits = new[]
            {
                Trait.Shugenja,
                Trait.Void
            };
            Keywords = new Keyword[0];
            IsUnique = true;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_92.jpg");
            AllowedClans = new[] { Clan.Phoenix };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
