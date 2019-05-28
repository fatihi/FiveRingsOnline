using CoreEngine.Cards.CartTypes;

namespace CoreEngine.Cards.CardsImpl
{
    public class AboveQuestionCard : AttachmentCard
    {
        public AboveQuestionCard()
        {
            Name = "Above Question";
            Cost = 1;
            MilitaryBonus = 0;
            PoliticalBonus = 0;
            Clan = Clan.Crane;
        }
    }
}
