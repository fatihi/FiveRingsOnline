using System;
using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class LionSPrideBrawlerCard : CharacterCard
    {
        public LionSPrideBrawlerCard()
        {
            Name = "Lion's Pride Brawler";
            Clan = Clan.Lion;
            Cost = 3;
            Glory = 1;
            Military = 3;
            Political = 2;
            Text = "<b>Action:</b> While this character is attacking, choose a character with equal or lower [conflict-military] skill than this character – bow that character.";
            Traits = new[]
            {
                Trait.Bushi,
                Trait.Courtier
            };
            Keywords = new Keyword[0];
            IsUnique = false;
            ImageUrl = new Uri("http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_75.jpg");
            AllowedClans = new[] { Clan.Lion };
            DeckLimit = 3;
            InfluenceCost = null;
            IsRestricted = false;
            Side = Side.Dynasty;
        }
    }
}
