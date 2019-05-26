namespace CoreEngine.Cards.CartTypes
{
    public abstract class AttachmentCard : Card
    {
        public int? Cost { get; set; }
        public int? MilitaryBonus { get; set; }
        public int? PoliticalBonus { get; set; }

        public new CardType Type => CardType.Attachment;
    }
}