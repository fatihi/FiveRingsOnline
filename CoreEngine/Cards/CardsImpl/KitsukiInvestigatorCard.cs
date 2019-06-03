using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class KitsukiInvestigatorCard : CharacterCard
    {
        public KitsukiInvestigatorCard()
        {
            Name = "Kitsuki Investigator";
            Clan = Clan.Dragon;
            Cost = 3;
            Glory = 2;
            Military = 1;
            Political = 3;
            Text = "<b>Action:</b> While this character is participating in a [conflict-political] conflict, spend 1 fate to an unclaimed ring – look at your opponent's hand. Choose 1 of those cards and discard it. (Max 1 per conflict.)";
            Traits = new[] { Trait.Courtier };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_61.jpg");
            AllowedClans = new[] { Clan.Dragon };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
